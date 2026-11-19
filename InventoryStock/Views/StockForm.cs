using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

// One form for the three stock operations: Purchase (receive), Sale, Adjustment
public partial class StockForm : Form
{
    private readonly string _mode;
    private readonly ProductController _products = new();
    private readonly SupplierController _suppliers = new();
    private readonly StockController _stock = new();
    private List<ProductRow> _rows = new();

    // parameterless constructor lets the Visual Studio designer open this form
    public StockForm() : this(TxTypes.Purchase) { }

    public StockForm(string mode)
    {
        _mode = mode;
        InitializeComponent();
        Text = mode switch
        {
            TxTypes.Purchase => "Receive Stock",
            TxTypes.Sale => "Record Sale",
            _ => "Adjust Stock"
        };
    }

    private void StockForm_Load(object? sender, EventArgs e)
    {
        var sup = new List<ComboItem> { new(0, "(none)") };
        sup.AddRange(_suppliers.GetAll(activeOnly: true).Select(s => new ComboItem(s.SupplierId, s.Name)));
        cmbSupplier.DataSource = sup;
        cmbSupplier.DisplayMember = "Text";
        cmbSupplier.ValueMember = "Id";

        // show only the controls that make sense for this operation
        bool purchase = _mode == TxTypes.Purchase, sale = _mode == TxTypes.Sale, adjust = _mode == TxTypes.Adjustment;
        lblSupplier.Visible = cmbSupplier.Visible = purchase;
        lblPrice.Visible = numPrice.Visible = !adjust;
        lblPrice.Text = purchase ? "Unit cost" : "Unit price";
        lblNotes.Text = adjust ? "Reason" : "Notes";
        lblQty.Text = adjust ? "Change (+/-)" : "Quantity";
        if (adjust) { numQty.Minimum = -1000000; numQty.Value = 0; }
        else { numQty.Minimum = 1; numQty.Value = 1; }
        btnSave.Text = purchase ? "Receive" : sale ? "Complete sale" : "Apply adjustment";

        LoadProducts();
        LoadGrid();
    }

    private void LoadProducts()
    {
        _rows = _products.Search();
        var items = _rows.Select(r => new ComboItem(r.Id, $"{r.Code} - {r.Name}")).ToList();
        cmbProduct.DataSource = items;
        cmbProduct.DisplayMember = "Text";
        cmbProduct.ValueMember = "Id";
        cmbProduct_SelectedIndexChanged(null, EventArgs.Empty);
    }

    private void LoadGrid()
        => dgvRecent.DataSource = _stock.GetHistory(_mode, DateTime.Today.AddDays(-30), DateTime.Today);

    private void cmbProduct_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cmbProduct.SelectedValue is not int id) return;
        var row = _rows.FirstOrDefault(r => r.Id == id);
        if (row == null) return;
        lblAvailable.Text = $"Available: {row.InStock}   (minimum {row.MinStock})";
        if (_mode == TxTypes.Sale) numPrice.Value = row.Price;
        else if (_mode == TxTypes.Purchase) numPrice.Value = row.Cost;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (cmbProduct.SelectedValue is not int productId) { Ui.Error("Choose a product."); return; }

        string err, reference;
        string notes = txtNotes.Text.Trim();
        switch (_mode)
        {
            case TxTypes.Purchase:
                int? supplierId = cmbSupplier.SelectedValue is int s && s > 0 ? s : null;
                err = _stock.Receive(productId, supplierId, (int)numQty.Value, numPrice.Value, notes, out reference);
                break;
            case TxTypes.Sale:
                err = _stock.Sell(productId, (int)numQty.Value, numPrice.Value, notes, out reference);
                break;
            default:
                err = _stock.Adjust(productId, (int)numQty.Value, notes, out reference);
                break;
        }

        if (err != "") { Ui.Error(err); return; }

        lblResult.Text = "Saved. Reference: " + reference;
        txtNotes.Clear();
        numQty.Value = _mode == TxTypes.Adjustment ? 0 : 1;
        int keep = productId;
        LoadProducts();
        cmbProduct.SelectedValue = keep;
        LoadGrid();
    }
}

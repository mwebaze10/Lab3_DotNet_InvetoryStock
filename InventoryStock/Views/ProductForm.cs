using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class ProductForm : Form
{
    private readonly ProductController _ctrl = new();
    private readonly CategoryController _cats = new();
    private readonly SupplierController _sups = new();
    private int _selectedId = 0;

    public ProductForm()
    {
        InitializeComponent();
    }

    private void ProductForm_Load(object? sender, EventArgs e)
    {
        cmbCategory.DataSource = _cats.GetAll();
        cmbCategory.DisplayMember = "Name";
        cmbCategory.ValueMember = "CategoryId";

        var sup = new List<ComboItem> { new(0, "(none)") };
        sup.AddRange(_sups.GetAll(activeOnly: true).Select(s => new ComboItem(s.SupplierId, s.Name)));
        cmbSupplier.DataSource = sup;
        cmbSupplier.DisplayMember = "Text";
        cmbSupplier.ValueMember = "Id";

        // only Administrator / Stock Manager may change the catalogue (FR03)
        bool edit = Session.CanManageCatalog;
        btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = edit;
        LoadGrid();
    }

    private void LoadGrid()
    {
        dgvProducts.DataSource = _ctrl.Search(txtSearch.Text);
        HighlightLowStock();
    }

    private void HighlightLowStock()
    {
        foreach (DataGridViewRow row in dgvProducts.Rows)
        {
            var status = row.Cells["colStatus"].Value?.ToString();
            if (status == "Out of stock") row.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            else if (status == "Low stock") row.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
        }
    }

    private Product ReadForm() => new()
    {
        ProductId = _selectedId,
        Code = txtCode.Text.Trim(),
        Name = txtName.Text.Trim(),
        CategoryId = cmbCategory.SelectedValue is int c ? c : 0,
        SupplierId = cmbSupplier.SelectedValue is int s && s > 0 ? s : null,
        CostPrice = numCost.Value,
        SellingPrice = numPrice.Value,
        MinStock = (int)numMin.Value
    };

    private void ClearForm()
    {
        _selectedId = 0;
        txtCode.Clear(); txtName.Clear();
        numCost.Value = 0; numPrice.Value = 0; numMin.Value = 0;
        lblQty.Text = "In stock: 0";
        if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
        cmbSupplier.SelectedIndex = 0;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var p = ReadForm();
        p.ProductId = 0;
        string err = _ctrl.Validate(p);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Add(p);
        Ui.Info("Product added. Use 'Receive Stock' to record its first quantity.");
        LoadGrid(); ClearForm();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a product first."); return; }
        var p = ReadForm();
        string err = _ctrl.Validate(p);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Update(p);
        LoadGrid(); ClearForm();
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a product first."); return; }
        if (!Ui.Confirm("Delete this product?")) return;
        string err = _ctrl.Delete(_selectedId);
        if (err != "") { Ui.Error(err); return; }
        LoadGrid(); ClearForm();
    }

    private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

    private void txtSearch_TextChanged(object? sender, EventArgs e) => LoadGrid();

    private void dgvProducts_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow?.DataBoundItem is not ProductRow row) return;
        var p = _ctrl.Get(row.Id);
        if (p == null) return;
        _selectedId = p.ProductId;
        txtCode.Text = p.Code; txtName.Text = p.Name;
        cmbCategory.SelectedValue = p.CategoryId;
        cmbSupplier.SelectedValue = p.SupplierId ?? 0;
        numCost.Value = p.CostPrice; numPrice.Value = p.SellingPrice; numMin.Value = p.MinStock;
        lblQty.Text = "In stock: " + p.Quantity;
    }
}

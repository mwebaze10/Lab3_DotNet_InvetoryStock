using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class MainForm : Form
{
    private readonly ProductController _products = new();
    private readonly BackupController _backup = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        var u = Session.CurrentUser!;
        lblWelcome.Text = $"Logged in: {u.FullName} ({u.Role})";

        // Role-based menus (FR14)
        mnuProducts.Enabled = true;                          // everyone can view stock levels and search
        mnuCategories.Visible = Session.CanManageCatalog;
        mnuSuppliers.Visible = Session.CanManageCatalog;
        mnuReceive.Visible = Session.CanReceiveStock;
        mnuAdjust.Visible = Session.CanReceiveStock;
        mnuSale.Visible = Session.CanSell;
        mnuReports.Visible = Session.CanViewReports;
        mnuAdmin.Visible = Session.CanManageUsers;

        RefreshAlert(showDialog: Session.CanViewReports || Session.CanSell);
    }

    // FR10: low-stock notification
    public void RefreshAlert(bool showDialog = false)
    {
        var low = _products.GetLowStock();
        lblAlert.Text = low.Count == 0 ? "Stock levels OK" : $"⚠ {low.Count} product(s) at or below minimum stock";
        lblAlert.ForeColor = low.Count == 0 ? System.Drawing.Color.DarkGreen : System.Drawing.Color.Firebrick;

        if (showDialog && low.Count > 0)
        {
            var lines = low.Take(10).Select(r => $"• {r.Code} {r.Name}: {r.InStock} left (min {r.MinStock})");
            string more = low.Count > 10 ? $"\n…and {low.Count - 10} more." : "";
            MessageBox.Show("Low-stock alert:\n\n" + string.Join("\n", lines) + more,
                "Low stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Opens a child form once; if it is already open, brings it to the front
    private void Open(Form f)
    {
        foreach (var c in MdiChildren)
            if (c.Text == f.Text) { f.Dispose(); c.Activate(); return; }
        f.MdiParent = this;
        f.FormClosed += (s, e) => RefreshAlert();
        f.Show();
    }

    private void mnuProducts_Click(object? sender, EventArgs e) => Open(new ProductForm());
    private void mnuCategories_Click(object? sender, EventArgs e) => Open(new CategoryForm());
    private void mnuSuppliers_Click(object? sender, EventArgs e) => Open(new SupplierForm());
    private void mnuReceive_Click(object? sender, EventArgs e) => Open(new StockForm(TxTypes.Purchase));
    private void mnuSale_Click(object? sender, EventArgs e) => Open(new StockForm(TxTypes.Sale));
    private void mnuAdjust_Click(object? sender, EventArgs e) => Open(new StockForm(TxTypes.Adjustment));
    private void mnuReports_Click(object? sender, EventArgs e) => Open(new ReportForm());
    private void mnuUsers_Click(object? sender, EventArgs e) => Open(new UserForm());

    private void mnuBackup_Click(object? sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        {
            Filter = "Inventory backup (*.db)|*.db",
            FileName = $"inventory-backup-{DateTime.Now:yyyyMMdd-HHmm}.db"
        };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        string err = _backup.Backup(dlg.FileName);
        if (err == "") Ui.Info("Backup saved to:\n" + dlg.FileName); else Ui.Error(err);
    }

    private void mnuRestore_Click(object? sender, EventArgs e)
    {
        using var dlg = new OpenFileDialog { Filter = "Inventory backup (*.db)|*.db" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        if (!Ui.Confirm("Restoring replaces ALL current data with the backup.\nThe application will close afterwards. Continue?")) return;

        string err = _backup.Restore(dlg.FileName);
        if (err != "") { Ui.Error(err); return; }
        Ui.Info("Backup restored. Please start the application again.");
        Application.Exit();
    }

    private void mnuLogout_Click(object? sender, EventArgs e) => Close();
}

using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class ReportForm : Form
{
    private readonly ReportController _reports = new();
    private readonly StockController _stock = new();
    private Action<string>? _export;     // exports whatever is currently in the grid

    public ReportForm()
    {
        InitializeComponent();
    }

    private void ReportForm_Load(object? sender, EventArgs e)
    {
        cmbReport.Items.AddRange(new object[]
        {
            "Inventory report (stock levels)", "Low-stock report", "Purchase report", "Sales report", "Transaction history"
        });
        cmbReport.SelectedIndex = 0;
        dtpFrom.Value = DateTime.Today.AddDays(-30);
        dtpTo.Value = DateTime.Today;
    }

    private void cmbReport_SelectedIndexChanged(object? sender, EventArgs e)
    {
        bool dated = cmbReport.SelectedIndex >= 2;
        lblFrom.Visible = dtpFrom.Visible = lblTo.Visible = dtpTo.Visible = dated;
        Run();
    }

    private void btnRun_Click(object? sender, EventArgs e) => Run();

    private void Run()
    {
        DateTime from = dtpFrom.Value.Date, to = dtpTo.Value.Date;
        if (from > to) { Ui.Error("'From' date must not be after 'To' date."); return; }

        switch (cmbReport.SelectedIndex)
        {
            case 0:
                var inv = _reports.InventoryReport();
                ShowRows(inv, $"{inv.Count} products. Stock value at cost: {_reports.InventoryValue():N2}");
                break;
            case 1:
                var low = new ProductController().GetLowStock();
                ShowRows(low, $"{low.Count} product(s) at or below minimum stock.");
                break;
            case 2:
                var pur = _reports.PurchaseReport(from, to);
                ShowRows(pur, $"{pur.Count} purchases. Total cost: {pur.Sum(r => r.Total):N2}");
                break;
            case 3:
                var sal = _reports.SalesReport(from, to);
                ShowRows(sal, $"{sal.Count} sales. Total revenue: {sal.Sum(r => r.Total):N2}");
                break;
            default:
                var all = _stock.GetHistory(null, from, to);
                ShowRows(all, $"{all.Count} transactions.");
                break;
        }
    }

    private void ShowRows<T>(List<T> rows, string summary)
    {
        dgvReport.DataSource = rows;
        if (dgvReport.Columns["Id"] != null) dgvReport.Columns["Id"]!.Visible = false;
        lblSummary.Text = summary;
        _export = path => ReportController.ExportCsv(rows, path);
    }

    private void btnExport_Click(object? sender, EventArgs e)
    {
        if (_export == null) return;
        using var dlg = new SaveFileDialog
        {
            Filter = "CSV file (*.csv)|*.csv",
            FileName = $"report-{DateTime.Now:yyyyMMdd-HHmm}.csv"
        };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try { _export(dlg.FileName); Ui.Info("Exported to:\n" + dlg.FileName); }
        catch (Exception ex) { Ui.Error("Export failed: " + ex.Message); }
    }
}

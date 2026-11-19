using System.Text;
using InventoryStock.Data;
using InventoryStock.Models;

namespace InventoryStock.Controllers;

public class ReportController
{
    private readonly ProductController _products = new();
    private readonly StockController _stock = new();

    // FR12: stock (inventory) report
    public List<ProductRow> InventoryReport() => _products.Search();

    // Purchase and sales reports are the transaction history filtered by type
    public List<TransactionRow> PurchaseReport(DateTime from, DateTime to) => _stock.GetHistory(TxTypes.Purchase, from, to);
    public List<TransactionRow> SalesReport(DateTime from, DateTime to) => _stock.GetHistory(TxTypes.Sale, from, to);

    public decimal InventoryValue() => InventoryReport().Sum(r => r.InStock * r.Cost);

    // Simple CSV export of whatever list is currently shown in the grid
    public static void ExportCsv<T>(IEnumerable<T> rows, string path)
    {
        var props = typeof(T).GetProperties();
        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", props.Select(p => Escape(p.Name))));
        foreach (var r in rows)
            sb.AppendLine(string.Join(",", props.Select(p => Escape(p.GetValue(r)?.ToString() ?? ""))));
        File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
    }

    private static string Escape(string s)
        => s.Contains(',') || s.Contains('"') || s.Contains('\n') ? "\"" + s.Replace("\"", "\"\"") + "\"" : s;
}

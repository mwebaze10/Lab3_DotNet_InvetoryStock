namespace InventoryStock.Models;

public static class TxTypes
{
    public const string Purchase = "Purchase";       // stock received from a supplier
    public const string Sale = "Sale";               // stock sold
    public const string Adjustment = "Adjustment";   // manual correction (+/-)
}

public class StockTransaction
{
    public int StockTransactionId { get; set; }
    public string Reference { get; set; } = "";      // e.g. PUR-20261119-0001
    public string Type { get; set; } = TxTypes.Purchase;
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int? SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public int Quantity { get; set; }                // always positive
    public int QuantityChange { get; set; }          // signed effect on stock
    public decimal UnitPrice { get; set; }
    public string Notes { get; set; } = "";
    public DateTime Date { get; set; } = DateTime.Now;
}

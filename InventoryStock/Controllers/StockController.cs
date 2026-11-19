using InventoryStock.Data;
using InventoryStock.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryStock.Controllers;

// All stock changes go through here so every movement is recorded (FR06, FR07, FR08, FR13)
public class StockController
{
    private static string NewRef(AppDbContext db, string prefix)
    {
        string stem = $"{prefix}-{DateTime.Now:yyyyMMdd}-";
        int count = db.Transactions.Count(t => t.Reference.StartsWith(stem));
        return stem + (count + 1).ToString("D4");
    }

    // Each method returns an error message, or "" on success; reference comes out through 'reference'.

    public string Receive(int productId, int? supplierId, int qty, decimal unitCost, string notes, out string reference)
    {
        reference = "";
        if (qty <= 0) return "Quantity must be greater than zero.";
        if (unitCost < 0) return "Unit cost cannot be negative.";
        return Apply(productId, supplierId, TxTypes.Purchase, qty, +qty, unitCost, notes, "PUR", out reference);
    }

    public string Sell(int productId, int qty, decimal unitPrice, string notes, out string reference)
    {
        reference = "";
        if (qty <= 0) return "Quantity must be greater than zero.";
        if (unitPrice < 0) return "Unit price cannot be negative.";
        return Apply(productId, null, TxTypes.Sale, qty, -qty, unitPrice, notes, "SAL", out reference);
    }

    // change may be positive or negative
    public string Adjust(int productId, int change, string reason, out string reference)
    {
        reference = "";
        if (change == 0) return "Adjustment cannot be zero.";
        if (string.IsNullOrWhiteSpace(reason)) return "Please give a reason for the adjustment.";
        return Apply(productId, null, TxTypes.Adjustment, Math.Abs(change), change, 0, reason, "ADJ", out reference);
    }

    private string Apply(int productId, int? supplierId, string type, int qty, int change,
                         decimal unitPrice, string notes, string prefix, out string reference)
    {
        reference = "";
        if (Session.CurrentUser == null) return "You must be logged in.";

        using var db = new AppDbContext();
        using var tx = db.Database.BeginTransaction();

        var product = db.Products.Find(productId);
        if (product == null) return "Product not found.";

        // Data integrity: never allow negative stock (NFR07, business rule: no sale without stock)
        if (product.Quantity + change < 0)
            return type == TxTypes.Sale
                ? $"Insufficient stock. Only {product.Quantity} of '{product.Name}' available."
                : $"Adjustment would make stock negative (current: {product.Quantity}).";

        product.Quantity += change;
        reference = NewRef(db, prefix);
        db.Transactions.Add(new StockTransaction
        {
            Reference = reference, Type = type, ProductId = productId, SupplierId = supplierId,
            UserId = Session.CurrentUser.UserId, Quantity = qty, QuantityChange = change,
            UnitPrice = unitPrice, Notes = notes, Date = DateTime.Now
        });
        db.SaveChanges();
        tx.Commit();
        return "";
    }

    // FR13: transaction history, optionally filtered by type and date range
    public List<TransactionRow> GetHistory(string? type, DateTime from, DateTime to)
    {
        using var db = new AppDbContext();
        DateTime end = to.Date.AddDays(1);
        var q = db.Transactions.Include(t => t.Product).Include(t => t.User)
                  .Where(t => t.Date >= from.Date && t.Date < end);
        if (!string.IsNullOrEmpty(type)) q = q.Where(t => t.Type == type);

        return q.OrderByDescending(t => t.Date).AsEnumerable().Select(t => new TransactionRow
        {
            Date = t.Date, Reference = t.Reference, Type = t.Type,
            Code = t.Product!.Code, Product = t.Product.Name,
            Change = t.QuantityChange, UnitPrice = t.UnitPrice,
            Total = t.UnitPrice * t.Quantity,
            User = t.User!.FullName, Notes = t.Notes
        }).ToList();
    }
}

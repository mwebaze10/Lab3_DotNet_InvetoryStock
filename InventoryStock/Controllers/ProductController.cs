using InventoryStock.Data;
using InventoryStock.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryStock.Controllers;

public class ProductController
{
    public string Validate(Product p)
    {
        if (string.IsNullOrWhiteSpace(p.Code)) return "Product code is required.";
        if (string.IsNullOrWhiteSpace(p.Name)) return "Product name is required.";
        if (p.CategoryId <= 0) return "Choose a category.";
        if (p.CostPrice < 0 || p.SellingPrice < 0) return "Prices cannot be negative.";
        if (p.MinStock < 0) return "Minimum stock cannot be negative.";

        using var db = new AppDbContext();
        string code = p.Code.ToLower();
        if (db.Products.Any(x => x.ProductId != p.ProductId && x.Code.ToLower() == code))
            return "A product with this code already exists.";
        return "";
    }

    private static string StatusOf(int qty, int min) =>
        qty <= 0 ? "Out of stock" : qty <= min ? "Low stock" : "OK";

    // FR09 + FR11: stock levels, searchable by name, category or code
    public List<ProductRow> Search(string term = "")
    {
        using var db = new AppDbContext();
        term = term.Trim().ToLower();
        var q = db.Products.Include(p => p.Category).Include(p => p.Supplier).AsQueryable();
        if (term.Length > 0)
            q = q.Where(p => p.Name.ToLower().Contains(term) || p.Code.ToLower().Contains(term)
                          || p.Category!.Name.ToLower().Contains(term));
        return q.OrderBy(p => p.Name).AsEnumerable().Select(p => new ProductRow
        {
            Id = p.ProductId, Code = p.Code, Name = p.Name,
            Category = p.Category!.Name, Supplier = p.Supplier?.Name ?? "",
            Cost = p.CostPrice, Price = p.SellingPrice,
            InStock = p.Quantity, MinStock = p.MinStock,
            Status = StatusOf(p.Quantity, p.MinStock)
        }).ToList();
    }

    public Product? Get(int id)
    {
        using var db = new AppDbContext();
        return db.Products.Find(id);
    }

    public List<Product> GetAll()
    {
        using var db = new AppDbContext();
        return db.Products.OrderBy(p => p.Name).ToList();
    }

    public void Add(Product p)
    {
        using var db = new AppDbContext();
        p.Quantity = 0;                 // stock only changes through recorded transactions
        db.Products.Add(p);
        db.SaveChanges();
    }

    public void Update(Product p)
    {
        using var db = new AppDbContext();
        var x = db.Products.Find(p.ProductId);
        if (x == null) return;
        x.Code = p.Code; x.Name = p.Name; x.CategoryId = p.CategoryId; x.SupplierId = p.SupplierId;
        x.CostPrice = p.CostPrice; x.SellingPrice = p.SellingPrice; x.MinStock = p.MinStock;
        db.SaveChanges();
    }

    // Returns an error message, or "" when deleted
    public string Delete(int id)
    {
        using var db = new AppDbContext();
        if (db.Transactions.Any(t => t.ProductId == id))
            return "This product has transaction history and cannot be deleted.";
        var x = db.Products.Find(id);
        if (x != null) { db.Products.Remove(x); db.SaveChanges(); }
        return "";
    }

    // FR10: products at or below their minimum level
    public List<ProductRow> GetLowStock()
        => Search().Where(r => r.InStock <= r.MinStock).OrderBy(r => r.InStock).ToList();
}

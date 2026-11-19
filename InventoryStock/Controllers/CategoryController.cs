using InventoryStock.Data;
using InventoryStock.Models;

namespace InventoryStock.Controllers;

public class CategoryController
{
    public string Validate(Category c)
    {
        if (string.IsNullOrWhiteSpace(c.Name)) return "Category name is required.";
        using var db = new AppDbContext();
        string n = c.Name.ToLower();
        if (db.Categories.Any(x => x.CategoryId != c.CategoryId && x.Name.ToLower() == n))
            return "A category with this name already exists.";
        return "";
    }

    public List<Category> GetAll()
    {
        using var db = new AppDbContext();
        return db.Categories.OrderBy(c => c.Name).ToList();
    }

    public void Add(Category c)
    {
        using var db = new AppDbContext();
        db.Categories.Add(c);
        db.SaveChanges();
    }

    public void Update(Category c)
    {
        using var db = new AppDbContext();
        var x = db.Categories.Find(c.CategoryId);
        if (x == null) return;
        x.Name = c.Name; x.Description = c.Description;
        db.SaveChanges();
    }

    // Returns an error message, or "" when deleted
    public string Delete(int id)
    {
        using var db = new AppDbContext();
        if (db.Products.Any(p => p.CategoryId == id))
            return "This category still has products. Move or delete them first.";
        var x = db.Categories.Find(id);
        if (x != null) { db.Categories.Remove(x); db.SaveChanges(); }
        return "";
    }
}

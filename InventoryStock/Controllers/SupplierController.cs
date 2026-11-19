using InventoryStock.Data;
using InventoryStock.Models;

namespace InventoryStock.Controllers;

public class SupplierController
{
    public string Validate(Supplier s)
    {
        if (string.IsNullOrWhiteSpace(s.Name)) return "Supplier name is required.";
        if (string.IsNullOrWhiteSpace(s.Phone)) return "Phone number is required.";
        if (!string.IsNullOrWhiteSpace(s.Email) && !s.Email.Contains('@')) return "Email is not valid.";
        using var db = new AppDbContext();
        string n = s.Name.ToLower();
        if (db.Suppliers.Any(x => x.SupplierId != s.SupplierId && x.Name.ToLower() == n))
            return "A supplier with this name already exists.";
        return "";
    }

    public List<Supplier> GetAll(bool activeOnly = false)
    {
        using var db = new AppDbContext();
        var q = db.Suppliers.AsQueryable();
        if (activeOnly) q = q.Where(s => s.IsActive);
        return q.OrderBy(s => s.Name).ToList();
    }

    public void Add(Supplier s)
    {
        using var db = new AppDbContext();
        db.Suppliers.Add(s);
        db.SaveChanges();
    }

    public void Update(Supplier s)
    {
        using var db = new AppDbContext();
        var x = db.Suppliers.Find(s.SupplierId);
        if (x == null) return;
        x.Name = s.Name; x.ContactPerson = s.ContactPerson; x.Phone = s.Phone;
        x.Email = s.Email; x.Address = s.Address; x.IsActive = s.IsActive;
        db.SaveChanges();
    }
}

using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (!db.Users.Any())
        {
            db.Users.AddRange(
                new User { Username = "admin",   FullName = "System Admin",  Email = "admin@inventory.local",
                           Role = Roles.Administrator, PasswordHash = AuthController.Hash("admin123") },
                new User { Username = "manager", FullName = "Stock Manager", Email = "manager@inventory.local",
                           Role = Roles.StockManager,  PasswordHash = AuthController.Hash("manager123") },
                new User { Username = "sales",   FullName = "Sales Staff",   Email = "sales@inventory.local",
                           Role = Roles.SalesStaff,    PasswordHash = AuthController.Hash("sales123") });
        }
        if (!db.Categories.Any())
        {
            db.Categories.AddRange(
                new Category { Name = "Electronics", Description = "Phones, chargers, accessories" },
                new Category { Name = "Groceries",   Description = "Food and household items" },
                new Category { Name = "Stationery",  Description = "Office and school supplies" });
        }
        if (!db.Suppliers.Any())
        {
            db.Suppliers.AddRange(
                new Supplier { Name = "Kigali Wholesale Ltd", ContactPerson = "Eric N.", Phone = "0788111222",
                               Email = "sales@kigaliwholesale.example", Address = "Kigali" },
                new Supplier { Name = "Rusizi Traders", ContactPerson = "Aline U.", Phone = "0788333444",
                               Email = "info@rusizitraders.example", Address = "Rusizi" });
        }
        db.SaveChanges();

        if (!db.Products.Any())
        {
            int el = db.Categories.First(c => c.Name == "Electronics").CategoryId;
            int gr = db.Categories.First(c => c.Name == "Groceries").CategoryId;
            int st = db.Categories.First(c => c.Name == "Stationery").CategoryId;
            int s1 = db.Suppliers.First().SupplierId;
            db.Products.AddRange(
                new Product { Code = "EL-001", Name = "USB Charger",   CategoryId = el, SupplierId = s1, CostPrice = 3000, SellingPrice = 5000, Quantity = 25, MinStock = 10 },
                new Product { Code = "GR-001", Name = "Rice 5kg",      CategoryId = gr, SupplierId = s1, CostPrice = 6000, SellingPrice = 7500, Quantity = 8,  MinStock = 10 },
                new Product { Code = "ST-001", Name = "Notebook A4",   CategoryId = st, SupplierId = s1, CostPrice = 500,  SellingPrice = 800,  Quantity = 100, MinStock = 20 });
            db.SaveChanges();

            // record the opening quantities as transactions so history matches stock (FR13)
            int adminId = db.Users.First(u => u.Role == Roles.Administrator).UserId;
            int n = 0;
            foreach (var p in db.Products.ToList())
            {
                db.Transactions.Add(new StockTransaction
                {
                    Reference = $"ADJ-{DateTime.Now:yyyyMMdd}-{++n:D4}", Type = TxTypes.Adjustment,
                    ProductId = p.ProductId, UserId = adminId, Quantity = p.Quantity,
                    QuantityChange = p.Quantity, Notes = "Opening stock", Date = DateTime.Now
                });
            }
            db.SaveChanges();
        }
    }
}

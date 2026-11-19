using Microsoft.EntityFrameworkCore;
using InventoryStock.Models;

namespace InventoryStock.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<StockTransaction> Transactions => Set<StockTransaction>();

    // The database file lives next to the .exe
    public static readonly string DbPath =
        Path.Combine(AppContext.BaseDirectory, "inventory.db");

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<User>().HasIndex(u => u.Username).IsUnique();
        b.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        b.Entity<Product>().HasIndex(p => p.Code).IsUnique();
        b.Entity<StockTransaction>().HasIndex(t => t.Reference).IsUnique();

        // SQLite has no native decimal; store as double-compatible REAL via conversion
        b.Entity<Product>().Property(p => p.CostPrice).HasConversion<double>();
        b.Entity<Product>().Property(p => p.SellingPrice).HasConversion<double>();
        b.Entity<StockTransaction>().Property(t => t.UnitPrice).HasConversion<double>();

        b.Entity<Product>().HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        b.Entity<Product>().HasOne(p => p.Supplier).WithMany().HasForeignKey(p => p.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
        b.Entity<StockTransaction>().HasOne(t => t.Product).WithMany().HasForeignKey(t => t.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

using System.ComponentModel;

namespace InventoryStock.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public int CategoryId { get; set; }
    public int? SupplierId { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int Quantity { get; set; }          // current stock on hand
    public int MinStock { get; set; }          // low-stock threshold
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Browsable(false)] public Category? Category { get; set; }
    [Browsable(false)] public Supplier? Supplier { get; set; }
}

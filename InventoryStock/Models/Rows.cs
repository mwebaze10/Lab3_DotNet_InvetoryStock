namespace InventoryStock.Models;

// Flat rows used to show data in DataGridViews (no navigation properties)
public class ProductRow
{
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public string Supplier { get; set; } = "";
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int MinStock { get; set; }
    public string Status { get; set; } = "";
}

public class TransactionRow
{
    public DateTime Date { get; set; }
    public string Reference { get; set; } = "";
    public string Type { get; set; } = "";
    public string Code { get; set; } = "";
    public string Product { get; set; } = "";
    public int Change { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Total { get; set; }
    public string User { get; set; } = "";
    public string Notes { get; set; } = "";
}

public class UserRow
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Role { get; set; } = "";
    public bool Active { get; set; }
}

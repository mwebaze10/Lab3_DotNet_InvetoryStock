namespace InventoryStock.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Role { get; set; } = Roles.SalesStaff;
    public bool IsActive { get; set; } = true;
}

public static class Roles
{
    public const string Administrator = "Administrator";
    public const string StockManager = "Stock Manager";
    public const string SalesStaff = "Sales Staff";
    public static readonly string[] All = { Administrator, StockManager, SalesStaff };
}

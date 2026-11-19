using InventoryStock.Models;

namespace InventoryStock.Controllers;

public static class Session
{
    public static User? CurrentUser { get; set; }

    private static string Role => CurrentUser?.Role ?? "";

    // Role-based permissions (FR14)
    public static bool IsAdmin => Role == Roles.Administrator;
    public static bool CanManageCatalog => Role is Roles.Administrator or Roles.StockManager;   // products, categories, suppliers
    public static bool CanReceiveStock => Role is Roles.Administrator or Roles.StockManager;    // purchases + adjustments
    public static bool CanSell => Role is Roles.Administrator or Roles.SalesStaff;
    public static bool CanViewReports => Role is Roles.Administrator or Roles.StockManager;
    public static bool CanManageUsers => IsAdmin;
    public static bool CanBackup => IsAdmin;
}

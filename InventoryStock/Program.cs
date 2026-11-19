using InventoryStock.Data;
using InventoryStock.Views;

namespace InventoryStock;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();   // creates inventory.db and the tables if missing
            DbSeeder.Seed(db);             // adds demo users, categories, suppliers and products once
        }

        Application.Run(new LoginForm());
    }
}

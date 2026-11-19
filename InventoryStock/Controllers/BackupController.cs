using Microsoft.Data.Sqlite;
using InventoryStock.Data;

namespace InventoryStock.Controllers;

// NFR09: database backup and recovery
public class BackupController
{
    public string Backup(string targetPath)
    {
        try
        {
            if (File.Exists(targetPath)) File.Delete(targetPath);
            using var con = new SqliteConnection($"Data Source={AppDbContext.DbPath}");
            con.Open();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "VACUUM INTO $path";          // consistent snapshot of the live database
            cmd.Parameters.AddWithValue("$path", targetPath);
            cmd.ExecuteNonQuery();
            return "";
        }
        catch (Exception ex) { return "Backup failed: " + ex.Message; }
    }

    public string Restore(string backupPath)
    {
        try
        {
            // check that the chosen file really is a SQLite database with our tables
            using (var con = new SqliteConnection($"Data Source={backupPath};Mode=ReadOnly"))
            {
                con.Open();
                using var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE name IN ('Users','Products','Transactions')";
                if (Convert.ToInt32(cmd.ExecuteScalar()) < 3) return "This file is not an Inventory Stock backup.";
            }
            SqliteConnection.ClearAllPools();               // release the live file
            File.Copy(backupPath, AppDbContext.DbPath, true);
            return "";
        }
        catch (Exception ex) { return "Restore failed: " + ex.Message; }
    }
}

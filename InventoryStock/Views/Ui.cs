namespace InventoryStock.Views;

// Item for combo boxes that need an id + display text
public class ComboItem
{
    public int Id { get; set; }
    public string Text { get; set; } = "";
    public ComboItem(int id, string text) { Id = id; Text = text; }
    public override string ToString() => Text;
}

// Message-box shortcuts used by the forms
public static class Ui
{
    public static void Info(string msg) => MessageBox.Show(msg, "Inventory Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
    public static void Error(string msg) => MessageBox.Show(msg, "Inventory Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    public static bool Confirm(string msg) =>
        MessageBox.Show(msg, "Inventory Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
}

using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class CategoryForm : Form
{
    private readonly CategoryController _ctrl = new();
    private int _selectedId = 0;

    public CategoryForm()
    {
        InitializeComponent();
    }

    private void CategoryForm_Load(object? sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        dgvCategories.DataSource = _ctrl.GetAll();
    }

    private Category ReadForm() => new() { CategoryId = _selectedId, Name = txtName.Text.Trim(), Description = txtDescription.Text.Trim() };

    private void ClearForm() { _selectedId = 0; txtName.Clear(); txtDescription.Clear(); }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var c = ReadForm(); c.CategoryId = 0;
        string err = _ctrl.Validate(c);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Add(c); LoadGrid(); ClearForm();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a category first."); return; }
        var c = ReadForm();
        string err = _ctrl.Validate(c);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Update(c); LoadGrid(); ClearForm();
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a category first."); return; }
        if (!Ui.Confirm("Delete this category?")) return;
        string err = _ctrl.Delete(_selectedId);
        if (err != "") { Ui.Error(err); return; }
        LoadGrid(); ClearForm();
    }

    private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

    private void dgvCategories_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvCategories.CurrentRow?.DataBoundItem is not Category c) return;
        _selectedId = c.CategoryId; txtName.Text = c.Name; txtDescription.Text = c.Description;
    }
}

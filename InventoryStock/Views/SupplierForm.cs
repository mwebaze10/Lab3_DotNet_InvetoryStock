using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class SupplierForm : Form
{
    private readonly SupplierController _ctrl = new();
    private int _selectedId = 0;

    public SupplierForm()
    {
        InitializeComponent();
    }

    private void SupplierForm_Load(object? sender, EventArgs e) => LoadGrid();

    private void LoadGrid()
    {
        dgvSuppliers.DataSource = _ctrl.GetAll();
    }

    private Supplier ReadForm() => new()
    {
        SupplierId = _selectedId, Name = txtName.Text.Trim(), ContactPerson = txtContact.Text.Trim(),
        Phone = txtPhone.Text.Trim(), Email = txtEmail.Text.Trim(), Address = txtAddress.Text.Trim(),
        IsActive = chkActive.Checked
    };

    private void ClearForm()
    {
        _selectedId = 0;
        txtName.Clear(); txtContact.Clear(); txtPhone.Clear(); txtEmail.Clear(); txtAddress.Clear();
        chkActive.Checked = true;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var s = ReadForm(); s.SupplierId = 0;
        string err = _ctrl.Validate(s);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Add(s); LoadGrid(); ClearForm();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a supplier first."); return; }
        var s = ReadForm();
        string err = _ctrl.Validate(s);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Update(s); LoadGrid(); ClearForm();
    }

    private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

    private void dgvSuppliers_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvSuppliers.CurrentRow?.DataBoundItem is not Supplier s) return;
        _selectedId = s.SupplierId;
        txtName.Text = s.Name; txtContact.Text = s.ContactPerson; txtPhone.Text = s.Phone;
        txtEmail.Text = s.Email; txtAddress.Text = s.Address; chkActive.Checked = s.IsActive;
    }
}

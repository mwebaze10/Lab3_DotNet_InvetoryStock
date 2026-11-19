using InventoryStock.Controllers;
using InventoryStock.Models;

namespace InventoryStock.Views;

public partial class UserForm : Form
{
    private readonly AuthController _ctrl = new();
    private int _selectedId = 0;

    public UserForm()
    {
        InitializeComponent();
    }

    private void UserForm_Load(object? sender, EventArgs e)
    {
        cmbRole.Items.AddRange(Roles.All);
        cmbRole.SelectedIndex = 2;
        LoadGrid();
    }

    private void LoadGrid()
    {
        dgvUsers.DataSource = _ctrl.GetAll();
    }

    private User ReadForm() => new()
    {
        UserId = _selectedId, Username = txtUsername.Text.Trim(), FullName = txtFullName.Text.Trim(),
        Email = txtEmail.Text.Trim(), Role = cmbRole.SelectedItem?.ToString() ?? "", IsActive = chkActive.Checked
    };

    private void ClearForm()
    {
        _selectedId = 0;
        txtUsername.Clear(); txtFullName.Clear(); txtEmail.Clear(); txtPassword.Clear();
        cmbRole.SelectedIndex = 2; chkActive.Checked = true;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var u = ReadForm(); u.UserId = 0;
        string err = _ctrl.Validate(u, txtPassword.Text, isNew: true);
        if (err != "") { Ui.Error(err); return; }
        _ctrl.Add(u, txtPassword.Text);
        LoadGrid(); ClearForm();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_selectedId == 0) { Ui.Error("Select a user first."); return; }
        var u = ReadForm();
        string err = _ctrl.Validate(u, txtPassword.Text, isNew: false);
        if (err == "") err = _ctrl.Update(u, txtPassword.Text);
        if (err != "") { Ui.Error(err); return; }
        LoadGrid(); ClearForm();
    }

    private void btnClear_Click(object? sender, EventArgs e) => ClearForm();

    private void dgvUsers_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvUsers.CurrentRow?.DataBoundItem is not UserRow r) return;
        _selectedId = r.Id;
        txtUsername.Text = r.Username; txtFullName.Text = r.FullName; txtEmail.Text = r.Email;
        cmbRole.SelectedItem = r.Role; chkActive.Checked = r.Active;
        txtPassword.Clear();
    }
}

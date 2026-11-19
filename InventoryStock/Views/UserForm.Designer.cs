#nullable disable
namespace InventoryStock.Views;

partial class UserForm
{
    /// <summary>Required designer variable.</summary>
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.dgvUsers = new System.Windows.Forms.DataGridView();
        this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.lblUsername = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.lblFullName = new System.Windows.Forms.Label();
        this.txtFullName = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblRole = new System.Windows.Forms.Label();
        this.cmbRole = new System.Windows.Forms.ComboBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.chkActive = new System.Windows.Forms.CheckBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.lblHint = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvUsers
        // 
        this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colFullName,
            this.colEmail,
            this.colRole,
            this.colActive});
        this.dgvUsers.AllowUserToAddRows = false;
        this.dgvUsers.AllowUserToDeleteRows = false;
        this.dgvUsers.AllowUserToResizeRows = false;
        this.dgvUsers.ReadOnly = true;
        this.dgvUsers.RowHeadersVisible = false;
        this.dgvUsers.MultiSelect = false;
        this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvUsers.AutoGenerateColumns = false;
        this.dgvUsers.Location = new System.Drawing.Point(10, 10);
        this.dgvUsers.Name = "dgvUsers";
        this.dgvUsers.Size = new System.Drawing.Size(560, 420);
        this.dgvUsers.TabIndex = 0;
        this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
        // 
        // colUsername
        // 
        this.colUsername.DataPropertyName = "Username";
        this.colUsername.HeaderText = "Username";
        this.colUsername.Name = "colUsername";
        this.colUsername.ReadOnly = true;
        // 
        // colFullName
        // 
        this.colFullName.DataPropertyName = "FullName";
        this.colFullName.HeaderText = "Full name";
        this.colFullName.Name = "colFullName";
        this.colFullName.ReadOnly = true;
        // 
        // colEmail
        // 
        this.colEmail.DataPropertyName = "Email";
        this.colEmail.HeaderText = "Email";
        this.colEmail.Name = "colEmail";
        this.colEmail.ReadOnly = true;
        // 
        // colRole
        // 
        this.colRole.DataPropertyName = "Role";
        this.colRole.HeaderText = "Role";
        this.colRole.Name = "colRole";
        this.colRole.ReadOnly = true;
        // 
        // colActive
        // 
        this.colActive.DataPropertyName = "Active";
        this.colActive.HeaderText = "Active";
        this.colActive.Name = "colActive";
        this.colActive.ReadOnly = true;
        this.colActive.FillWeight = 40F;
        // 
        // lblUsername
        // 
        this.lblUsername.AutoSize = true;
        this.lblUsername.Location = new System.Drawing.Point(590, 13);
        this.lblUsername.Name = "lblUsername";
        this.lblUsername.Text = "Username";
        // 
        // txtUsername
        // 
        this.txtUsername.Location = new System.Drawing.Point(690, 10);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(190, 23);
        this.txtUsername.TabIndex = 1;
        // 
        // lblFullName
        // 
        this.lblFullName.AutoSize = true;
        this.lblFullName.Location = new System.Drawing.Point(590, 48);
        this.lblFullName.Name = "lblFullName";
        this.lblFullName.Text = "Full name";
        // 
        // txtFullName
        // 
        this.txtFullName.Location = new System.Drawing.Point(690, 45);
        this.txtFullName.Name = "txtFullName";
        this.txtFullName.Size = new System.Drawing.Size(190, 23);
        this.txtFullName.TabIndex = 2;
        // 
        // lblEmail
        // 
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(590, 83);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(690, 80);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(190, 23);
        this.txtEmail.TabIndex = 3;
        // 
        // lblRole
        // 
        this.lblRole.AutoSize = true;
        this.lblRole.Location = new System.Drawing.Point(590, 118);
        this.lblRole.Name = "lblRole";
        this.lblRole.Text = "Role";
        // 
        // cmbRole
        // 
        this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbRole.FormattingEnabled = true;
        this.cmbRole.Location = new System.Drawing.Point(690, 115);
        this.cmbRole.Name = "cmbRole";
        this.cmbRole.Size = new System.Drawing.Size(190, 23);
        this.cmbRole.TabIndex = 4;
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(590, 153);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        this.txtPassword.UseSystemPasswordChar = true;
        this.txtPassword.Location = new System.Drawing.Point(690, 150);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(190, 23);
        this.txtPassword.TabIndex = 5;
        // 
        // chkActive
        // 
        this.chkActive.UseVisualStyleBackColor = true;
        this.chkActive.Checked = true;
        this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkActive.Location = new System.Drawing.Point(690, 185);
        this.chkActive.Name = "chkActive";
        this.chkActive.Size = new System.Drawing.Size(100, 22);
        this.chkActive.TabIndex = 6;
        this.chkActive.Text = "Active";
        // 
        // btnAdd
        // 
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Location = new System.Drawing.Point(590, 225);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(90, 30);
        this.btnAdd.TabIndex = 7;
        this.btnAdd.Text = "Add";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnUpdate
        // 
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Location = new System.Drawing.Point(690, 225);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(90, 30);
        this.btnUpdate.TabIndex = 8;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        // 
        // btnClear
        // 
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Location = new System.Drawing.Point(790, 225);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(90, 30);
        this.btnClear.TabIndex = 9;
        this.btnClear.Text = "Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // lblHint
        // 
        this.lblHint.ForeColor = System.Drawing.Color.Gray;
        this.lblHint.Location = new System.Drawing.Point(590, 265);
        this.lblHint.Name = "lblHint";
        this.lblHint.Size = new System.Drawing.Size(290, 40);
        this.lblHint.Text = "When updating, leave Password empty to keep the current one.";
        // 
        // UserForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 440);
        this.Controls.Add(this.dgvUsers);
        this.Controls.Add(this.lblUsername);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.lblFullName);
        this.Controls.Add(this.txtFullName);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblRole);
        this.Controls.Add(this.cmbRole);
        this.Controls.Add(this.lblPassword);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.chkActive);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.lblHint);
        this.Name = "UserForm";
        this.Text = "Users";
        this.Load += new System.EventHandler(this.UserForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dgvUsers;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblFullName;
    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblRole;
    private System.Windows.Forms.ComboBox cmbRole;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.CheckBox chkActive;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblHint;
}

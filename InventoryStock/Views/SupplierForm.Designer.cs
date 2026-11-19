#nullable disable
namespace InventoryStock.Views;

partial class SupplierForm
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
        this.dgvSuppliers = new System.Windows.Forms.DataGridView();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblContact = new System.Windows.Forms.Label();
        this.txtContact = new System.Windows.Forms.TextBox();
        this.lblPhone = new System.Windows.Forms.Label();
        this.txtPhone = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblAddress = new System.Windows.Forms.Label();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.chkActive = new System.Windows.Forms.CheckBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvSuppliers
        // 
        this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colContactPerson,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colIsActive});
        this.dgvSuppliers.AllowUserToAddRows = false;
        this.dgvSuppliers.AllowUserToDeleteRows = false;
        this.dgvSuppliers.AllowUserToResizeRows = false;
        this.dgvSuppliers.ReadOnly = true;
        this.dgvSuppliers.RowHeadersVisible = false;
        this.dgvSuppliers.MultiSelect = false;
        this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvSuppliers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvSuppliers.AutoGenerateColumns = false;
        this.dgvSuppliers.Location = new System.Drawing.Point(10, 10);
        this.dgvSuppliers.Name = "dgvSuppliers";
        this.dgvSuppliers.Size = new System.Drawing.Size(620, 420);
        this.dgvSuppliers.TabIndex = 0;
        this.dgvSuppliers.SelectionChanged += new System.EventHandler(this.dgvSuppliers_SelectionChanged);
        // 
        // colName
        // 
        this.colName.DataPropertyName = "Name";
        this.colName.HeaderText = "Name";
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        // 
        // colContactPerson
        // 
        this.colContactPerson.DataPropertyName = "ContactPerson";
        this.colContactPerson.HeaderText = "Contact person";
        this.colContactPerson.Name = "colContactPerson";
        this.colContactPerson.ReadOnly = true;
        // 
        // colPhone
        // 
        this.colPhone.DataPropertyName = "Phone";
        this.colPhone.HeaderText = "Phone";
        this.colPhone.Name = "colPhone";
        this.colPhone.ReadOnly = true;
        // 
        // colEmail
        // 
        this.colEmail.DataPropertyName = "Email";
        this.colEmail.HeaderText = "Email";
        this.colEmail.Name = "colEmail";
        this.colEmail.ReadOnly = true;
        // 
        // colAddress
        // 
        this.colAddress.DataPropertyName = "Address";
        this.colAddress.HeaderText = "Address";
        this.colAddress.Name = "colAddress";
        this.colAddress.ReadOnly = true;
        // 
        // colIsActive
        // 
        this.colIsActive.DataPropertyName = "IsActive";
        this.colIsActive.HeaderText = "Active";
        this.colIsActive.Name = "colIsActive";
        this.colIsActive.ReadOnly = true;
        this.colIsActive.FillWeight = 40F;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(650, 13);
        this.lblName.Name = "lblName";
        this.lblName.Text = "Name";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(750, 10);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(190, 23);
        this.txtName.TabIndex = 1;
        // 
        // lblContact
        // 
        this.lblContact.AutoSize = true;
        this.lblContact.Location = new System.Drawing.Point(650, 48);
        this.lblContact.Name = "lblContact";
        this.lblContact.Text = "Contact person";
        // 
        // txtContact
        // 
        this.txtContact.Location = new System.Drawing.Point(750, 45);
        this.txtContact.Name = "txtContact";
        this.txtContact.Size = new System.Drawing.Size(190, 23);
        this.txtContact.TabIndex = 2;
        // 
        // lblPhone
        // 
        this.lblPhone.AutoSize = true;
        this.lblPhone.Location = new System.Drawing.Point(650, 83);
        this.lblPhone.Name = "lblPhone";
        this.lblPhone.Text = "Phone";
        // 
        // txtPhone
        // 
        this.txtPhone.Location = new System.Drawing.Point(750, 80);
        this.txtPhone.Name = "txtPhone";
        this.txtPhone.Size = new System.Drawing.Size(190, 23);
        this.txtPhone.TabIndex = 3;
        // 
        // lblEmail
        // 
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(650, 118);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(750, 115);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(190, 23);
        this.txtEmail.TabIndex = 4;
        // 
        // lblAddress
        // 
        this.lblAddress.AutoSize = true;
        this.lblAddress.Location = new System.Drawing.Point(650, 153);
        this.lblAddress.Name = "lblAddress";
        this.lblAddress.Text = "Address";
        // 
        // txtAddress
        // 
        this.txtAddress.Location = new System.Drawing.Point(750, 150);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(190, 23);
        this.txtAddress.TabIndex = 5;
        // 
        // chkActive
        // 
        this.chkActive.UseVisualStyleBackColor = true;
        this.chkActive.Checked = true;
        this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkActive.Location = new System.Drawing.Point(750, 185);
        this.chkActive.Name = "chkActive";
        this.chkActive.Size = new System.Drawing.Size(100, 22);
        this.chkActive.TabIndex = 6;
        this.chkActive.Text = "Active";
        // 
        // btnAdd
        // 
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Location = new System.Drawing.Point(650, 225);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(90, 30);
        this.btnAdd.TabIndex = 7;
        this.btnAdd.Text = "Add";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnUpdate
        // 
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Location = new System.Drawing.Point(750, 225);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(90, 30);
        this.btnUpdate.TabIndex = 8;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        // 
        // btnClear
        // 
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Location = new System.Drawing.Point(850, 225);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(90, 30);
        this.btnClear.TabIndex = 9;
        this.btnClear.Text = "Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // SupplierForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(960, 440);
        this.Controls.Add(this.dgvSuppliers);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblContact);
        this.Controls.Add(this.txtContact);
        this.Controls.Add(this.lblPhone);
        this.Controls.Add(this.txtPhone);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblAddress);
        this.Controls.Add(this.txtAddress);
        this.Controls.Add(this.chkActive);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnClear);
        this.Name = "SupplierForm";
        this.Text = "Suppliers";
        this.Load += new System.EventHandler(this.SupplierForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dgvSuppliers;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblContact;
    private System.Windows.Forms.TextBox txtContact;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.CheckBox chkActive;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
}

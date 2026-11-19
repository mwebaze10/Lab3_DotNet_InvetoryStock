#nullable disable
namespace InventoryStock.Views;

partial class CategoryForm
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
        this.dgvCategories = new System.Windows.Forms.DataGridView();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblDescription = new System.Windows.Forms.Label();
        this.txtDescription = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvCategories
        // 
        this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDescription});
        this.dgvCategories.AllowUserToAddRows = false;
        this.dgvCategories.AllowUserToDeleteRows = false;
        this.dgvCategories.AllowUserToResizeRows = false;
        this.dgvCategories.ReadOnly = true;
        this.dgvCategories.RowHeadersVisible = false;
        this.dgvCategories.MultiSelect = false;
        this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvCategories.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvCategories.AutoGenerateColumns = false;
        this.dgvCategories.Location = new System.Drawing.Point(10, 10);
        this.dgvCategories.Name = "dgvCategories";
        this.dgvCategories.Size = new System.Drawing.Size(480, 420);
        this.dgvCategories.TabIndex = 0;
        this.dgvCategories.SelectionChanged += new System.EventHandler(this.dgvCategories_SelectionChanged);
        // 
        // colName
        // 
        this.colName.DataPropertyName = "Name";
        this.colName.HeaderText = "Name";
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        this.colName.FillWeight = 40F;
        // 
        // colDescription
        // 
        this.colDescription.DataPropertyName = "Description";
        this.colDescription.HeaderText = "Description";
        this.colDescription.Name = "colDescription";
        this.colDescription.ReadOnly = true;
        this.colDescription.FillWeight = 60F;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(510, 13);
        this.lblName.Name = "lblName";
        this.lblName.Text = "Name";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(600, 10);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(190, 23);
        this.txtName.TabIndex = 1;
        // 
        // lblDescription
        // 
        this.lblDescription.AutoSize = true;
        this.lblDescription.Location = new System.Drawing.Point(510, 48);
        this.lblDescription.Name = "lblDescription";
        this.lblDescription.Text = "Description";
        // 
        // txtDescription
        // 
        this.txtDescription.Location = new System.Drawing.Point(600, 45);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(190, 23);
        this.txtDescription.TabIndex = 2;
        // 
        // btnAdd
        // 
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Location = new System.Drawing.Point(510, 90);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(90, 30);
        this.btnAdd.TabIndex = 3;
        this.btnAdd.Text = "Add";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnUpdate
        // 
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Location = new System.Drawing.Point(610, 90);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(90, 30);
        this.btnUpdate.TabIndex = 4;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        // 
        // btnDelete
        // 
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Location = new System.Drawing.Point(710, 90);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(90, 30);
        this.btnDelete.TabIndex = 5;
        this.btnDelete.Text = "Delete";
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        // 
        // btnClear
        // 
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Location = new System.Drawing.Point(510, 130);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(90, 30);
        this.btnClear.TabIndex = 6;
        this.btnClear.Text = "Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // CategoryForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(820, 440);
        this.Controls.Add(this.dgvCategories);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblDescription);
        this.Controls.Add(this.txtDescription);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnClear);
        this.Name = "CategoryForm";
        this.Text = "Categories";
        this.Load += new System.EventHandler(this.CategoryForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCategories;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
}

#nullable disable
namespace InventoryStock.Views;

partial class ProductForm
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
        System.Windows.Forms.DataGridViewCellStyle style1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle style2 = new System.Windows.Forms.DataGridViewCellStyle();
        this.lblSearch = new System.Windows.Forms.Label();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.dgvProducts = new System.Windows.Forms.DataGridView();
        this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblHeader = new System.Windows.Forms.Label();
        this.lblCode = new System.Windows.Forms.Label();
        this.txtCode = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblCategory = new System.Windows.Forms.Label();
        this.cmbCategory = new System.Windows.Forms.ComboBox();
        this.lblSupplier = new System.Windows.Forms.Label();
        this.cmbSupplier = new System.Windows.Forms.ComboBox();
        this.lblCost = new System.Windows.Forms.Label();
        this.numCost = new System.Windows.Forms.NumericUpDown();
        this.lblPrice = new System.Windows.Forms.Label();
        this.numPrice = new System.Windows.Forms.NumericUpDown();
        this.lblMin = new System.Windows.Forms.Label();
        this.numMin = new System.Windows.Forms.NumericUpDown();
        this.lblQty = new System.Windows.Forms.Label();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.lblHint = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
        this.SuspendLayout();
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Location = new System.Drawing.Point(10, 13);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Text = "Search (name, category or code)";
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new System.Drawing.Point(205, 10);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(250, 23);
        this.txtSearch.TabIndex = 0;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // dgvProducts
        // 
        this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colCategory,
            this.colSupplier,
            this.colCost,
            this.colPrice,
            this.colInStock,
            this.colMinStock,
            this.colStatus});
        this.dgvProducts.AllowUserToAddRows = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.AllowUserToResizeRows = false;
        this.dgvProducts.ReadOnly = true;
        this.dgvProducts.RowHeadersVisible = false;
        this.dgvProducts.MultiSelect = false;
        this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.AutoGenerateColumns = false;
        this.dgvProducts.Location = new System.Drawing.Point(10, 45);
        this.dgvProducts.Name = "dgvProducts";
        this.dgvProducts.Size = new System.Drawing.Size(770, 500);
        this.dgvProducts.TabIndex = 1;
        this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
        // 
        // colCode
        // 
        this.colCode.DataPropertyName = "Code";
        this.colCode.HeaderText = "Code";
        this.colCode.Name = "colCode";
        this.colCode.ReadOnly = true;
        this.colCode.FillWeight = 70F;
        // 
        // colName
        // 
        this.colName.DataPropertyName = "Name";
        this.colName.HeaderText = "Name";
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        this.colName.FillWeight = 120F;
        // 
        // colCategory
        // 
        this.colCategory.DataPropertyName = "Category";
        this.colCategory.HeaderText = "Category";
        this.colCategory.Name = "colCategory";
        this.colCategory.ReadOnly = true;
        this.colCategory.FillWeight = 80F;
        // 
        // colSupplier
        // 
        this.colSupplier.DataPropertyName = "Supplier";
        this.colSupplier.HeaderText = "Supplier";
        this.colSupplier.Name = "colSupplier";
        this.colSupplier.ReadOnly = true;
        this.colSupplier.FillWeight = 100F;
        // 
        // colCost
        // 
        this.colCost.DataPropertyName = "Cost";
        this.colCost.HeaderText = "Cost";
        this.colCost.Name = "colCost";
        this.colCost.ReadOnly = true;
        style1.Format = "N2";
        this.colCost.DefaultCellStyle = style1;
        this.colCost.FillWeight = 60F;
        // 
        // colPrice
        // 
        this.colPrice.DataPropertyName = "Price";
        this.colPrice.HeaderText = "Price";
        this.colPrice.Name = "colPrice";
        this.colPrice.ReadOnly = true;
        style2.Format = "N2";
        this.colPrice.DefaultCellStyle = style2;
        this.colPrice.FillWeight = 60F;
        // 
        // colInStock
        // 
        this.colInStock.DataPropertyName = "InStock";
        this.colInStock.HeaderText = "In stock";
        this.colInStock.Name = "colInStock";
        this.colInStock.ReadOnly = true;
        this.colInStock.FillWeight = 55F;
        // 
        // colMinStock
        // 
        this.colMinStock.DataPropertyName = "MinStock";
        this.colMinStock.HeaderText = "Min";
        this.colMinStock.Name = "colMinStock";
        this.colMinStock.ReadOnly = true;
        this.colMinStock.FillWeight = 40F;
        // 
        // colStatus
        // 
        this.colStatus.DataPropertyName = "Status";
        this.colStatus.HeaderText = "Status";
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        this.colStatus.FillWeight = 80F;
        // 
        // lblHeader
        // 
        this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHeader.Location = new System.Drawing.Point(800, 10);
        this.lblHeader.Name = "lblHeader";
        this.lblHeader.Size = new System.Drawing.Size(200, 24);
        this.lblHeader.Text = "Product details";
        // 
        // lblCode
        // 
        this.lblCode.AutoSize = true;
        this.lblCode.Location = new System.Drawing.Point(800, 48);
        this.lblCode.Name = "lblCode";
        this.lblCode.Text = "Code";
        // 
        // txtCode
        // 
        this.txtCode.Location = new System.Drawing.Point(910, 45);
        this.txtCode.Name = "txtCode";
        this.txtCode.Size = new System.Drawing.Size(170, 23);
        this.txtCode.TabIndex = 2;
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(800, 83);
        this.lblName.Name = "lblName";
        this.lblName.Text = "Name";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(910, 80);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(170, 23);
        this.txtName.TabIndex = 3;
        // 
        // lblCategory
        // 
        this.lblCategory.AutoSize = true;
        this.lblCategory.Location = new System.Drawing.Point(800, 118);
        this.lblCategory.Name = "lblCategory";
        this.lblCategory.Text = "Category";
        // 
        // cmbCategory
        // 
        this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbCategory.FormattingEnabled = true;
        this.cmbCategory.Location = new System.Drawing.Point(910, 115);
        this.cmbCategory.Name = "cmbCategory";
        this.cmbCategory.Size = new System.Drawing.Size(170, 23);
        this.cmbCategory.TabIndex = 4;
        // 
        // lblSupplier
        // 
        this.lblSupplier.AutoSize = true;
        this.lblSupplier.Location = new System.Drawing.Point(800, 153);
        this.lblSupplier.Name = "lblSupplier";
        this.lblSupplier.Text = "Supplier";
        // 
        // cmbSupplier
        // 
        this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSupplier.FormattingEnabled = true;
        this.cmbSupplier.Location = new System.Drawing.Point(910, 150);
        this.cmbSupplier.Name = "cmbSupplier";
        this.cmbSupplier.Size = new System.Drawing.Size(170, 23);
        this.cmbSupplier.TabIndex = 5;
        // 
        // lblCost
        // 
        this.lblCost.AutoSize = true;
        this.lblCost.Location = new System.Drawing.Point(800, 188);
        this.lblCost.Name = "lblCost";
        this.lblCost.Text = "Cost price";
        // 
        // numCost
        // 
        this.numCost.DecimalPlaces = 2;
        this.numCost.Maximum = new decimal(new int[] {100000000,0,0,0});
        this.numCost.ThousandsSeparator = true;
        this.numCost.Location = new System.Drawing.Point(910, 185);
        this.numCost.Name = "numCost";
        this.numCost.Size = new System.Drawing.Size(170, 23);
        this.numCost.TabIndex = 6;
        // 
        // lblPrice
        // 
        this.lblPrice.AutoSize = true;
        this.lblPrice.Location = new System.Drawing.Point(800, 223);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Text = "Selling price";
        // 
        // numPrice
        // 
        this.numPrice.DecimalPlaces = 2;
        this.numPrice.Maximum = new decimal(new int[] {100000000,0,0,0});
        this.numPrice.ThousandsSeparator = true;
        this.numPrice.Location = new System.Drawing.Point(910, 220);
        this.numPrice.Name = "numPrice";
        this.numPrice.Size = new System.Drawing.Size(170, 23);
        this.numPrice.TabIndex = 7;
        // 
        // lblMin
        // 
        this.lblMin.AutoSize = true;
        this.lblMin.Location = new System.Drawing.Point(800, 258);
        this.lblMin.Name = "lblMin";
        this.lblMin.Text = "Minimum stock";
        // 
        // numMin
        // 
        this.numMin.DecimalPlaces = 0;
        this.numMin.Maximum = new decimal(new int[] {1000000,0,0,0});
        this.numMin.ThousandsSeparator = true;
        this.numMin.Location = new System.Drawing.Point(910, 255);
        this.numMin.Name = "numMin";
        this.numMin.Size = new System.Drawing.Size(170, 23);
        this.numMin.TabIndex = 8;
        // 
        // lblQty
        // 
        this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblQty.Location = new System.Drawing.Point(910, 290);
        this.lblQty.Name = "lblQty";
        this.lblQty.Size = new System.Drawing.Size(170, 20);
        this.lblQty.Text = "In stock: 0";
        // 
        // btnAdd
        // 
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Location = new System.Drawing.Point(800, 330);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(90, 30);
        this.btnAdd.TabIndex = 9;
        this.btnAdd.Text = "Add";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnUpdate
        // 
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Location = new System.Drawing.Point(900, 330);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(90, 30);
        this.btnUpdate.TabIndex = 10;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        // 
        // btnDelete
        // 
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Location = new System.Drawing.Point(1000, 330);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(90, 30);
        this.btnDelete.TabIndex = 11;
        this.btnDelete.Text = "Delete";
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        // 
        // btnClear
        // 
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Location = new System.Drawing.Point(800, 370);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(90, 30);
        this.btnClear.TabIndex = 12;
        this.btnClear.Text = "Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // lblHint
        // 
        this.lblHint.ForeColor = System.Drawing.Color.Gray;
        this.lblHint.Location = new System.Drawing.Point(800, 415);
        this.lblHint.Name = "lblHint";
        this.lblHint.Size = new System.Drawing.Size(290, 55);
        this.lblHint.Text = "Quantity changes only through Receive Stock, Record Sale or Adjust Stock.";
        // 
        // ProductForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1100, 560);
        this.Controls.Add(this.lblSearch);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.dgvProducts);
        this.Controls.Add(this.lblHeader);
        this.Controls.Add(this.lblCode);
        this.Controls.Add(this.txtCode);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblCategory);
        this.Controls.Add(this.cmbCategory);
        this.Controls.Add(this.lblSupplier);
        this.Controls.Add(this.cmbSupplier);
        this.Controls.Add(this.lblCost);
        this.Controls.Add(this.numCost);
        this.Controls.Add(this.lblPrice);
        this.Controls.Add(this.numPrice);
        this.Controls.Add(this.lblMin);
        this.Controls.Add(this.numMin);
        this.Controls.Add(this.lblQty);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.lblHint);
        this.Name = "ProductForm";
        this.Text = "Products";
        this.Load += new System.EventHandler(this.ProductForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.DataGridView dgvProducts;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colInStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMinStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblCode;
    private System.Windows.Forms.TextBox txtCode;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblCategory;
    private System.Windows.Forms.ComboBox cmbCategory;
    private System.Windows.Forms.Label lblSupplier;
    private System.Windows.Forms.ComboBox cmbSupplier;
    private System.Windows.Forms.Label lblCost;
    private System.Windows.Forms.NumericUpDown numCost;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.NumericUpDown numPrice;
    private System.Windows.Forms.Label lblMin;
    private System.Windows.Forms.NumericUpDown numMin;
    private System.Windows.Forms.Label lblQty;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblHint;
}

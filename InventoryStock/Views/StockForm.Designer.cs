#nullable disable
namespace InventoryStock.Views;

partial class StockForm
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
        System.Windows.Forms.DataGridViewCellStyle style3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.lblProduct = new System.Windows.Forms.Label();
        this.cmbProduct = new System.Windows.Forms.ComboBox();
        this.lblAvailable = new System.Windows.Forms.Label();
        this.lblSupplier = new System.Windows.Forms.Label();
        this.cmbSupplier = new System.Windows.Forms.ComboBox();
        this.lblQty = new System.Windows.Forms.Label();
        this.numQty = new System.Windows.Forms.NumericUpDown();
        this.lblPrice = new System.Windows.Forms.Label();
        this.numPrice = new System.Windows.Forms.NumericUpDown();
        this.lblNotes = new System.Windows.Forms.Label();
        this.txtNotes = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.lblResult = new System.Windows.Forms.Label();
        this.lblRecent = new System.Windows.Forms.Label();
        this.dgvRecent = new System.Windows.Forms.DataGridView();
        this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
        this.SuspendLayout();
        // 
        // lblProduct
        // 
        this.lblProduct.AutoSize = true;
        this.lblProduct.Location = new System.Drawing.Point(10, 13);
        this.lblProduct.Name = "lblProduct";
        this.lblProduct.Text = "Product";
        // 
        // cmbProduct
        // 
        this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbProduct.FormattingEnabled = true;
        this.cmbProduct.Location = new System.Drawing.Point(110, 10);
        this.cmbProduct.Name = "cmbProduct";
        this.cmbProduct.Size = new System.Drawing.Size(300, 23);
        this.cmbProduct.TabIndex = 0;
        this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
        // 
        // lblAvailable
        // 
        this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAvailable.Location = new System.Drawing.Point(110, 40);
        this.lblAvailable.Name = "lblAvailable";
        this.lblAvailable.Size = new System.Drawing.Size(300, 20);
        this.lblAvailable.Text = "Available: 0   (minimum 0)";
        // 
        // lblSupplier
        // 
        this.lblSupplier.AutoSize = true;
        this.lblSupplier.Location = new System.Drawing.Point(10, 73);
        this.lblSupplier.Name = "lblSupplier";
        this.lblSupplier.Text = "Supplier";
        // 
        // cmbSupplier
        // 
        this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSupplier.FormattingEnabled = true;
        this.cmbSupplier.Location = new System.Drawing.Point(110, 70);
        this.cmbSupplier.Name = "cmbSupplier";
        this.cmbSupplier.Size = new System.Drawing.Size(300, 23);
        this.cmbSupplier.TabIndex = 1;
        // 
        // lblQty
        // 
        this.lblQty.AutoSize = true;
        this.lblQty.Location = new System.Drawing.Point(10, 108);
        this.lblQty.Name = "lblQty";
        this.lblQty.Text = "Quantity";
        // 
        // numQty
        // 
        this.numQty.DecimalPlaces = 0;
        this.numQty.Maximum = new decimal(new int[] {1000000,0,0,0});
        this.numQty.ThousandsSeparator = true;
        this.numQty.Minimum = new decimal(new int[] {1000000,0,0,-2147483648});
        this.numQty.Location = new System.Drawing.Point(110, 105);
        this.numQty.Name = "numQty";
        this.numQty.Size = new System.Drawing.Size(120, 23);
        this.numQty.TabIndex = 2;
        // 
        // lblPrice
        // 
        this.lblPrice.AutoSize = true;
        this.lblPrice.Location = new System.Drawing.Point(10, 143);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Text = "Unit price";
        // 
        // numPrice
        // 
        this.numPrice.DecimalPlaces = 2;
        this.numPrice.Maximum = new decimal(new int[] {100000000,0,0,0});
        this.numPrice.ThousandsSeparator = true;
        this.numPrice.Location = new System.Drawing.Point(110, 140);
        this.numPrice.Name = "numPrice";
        this.numPrice.Size = new System.Drawing.Size(120, 23);
        this.numPrice.TabIndex = 3;
        // 
        // lblNotes
        // 
        this.lblNotes.AutoSize = true;
        this.lblNotes.Location = new System.Drawing.Point(10, 178);
        this.lblNotes.Name = "lblNotes";
        this.lblNotes.Text = "Notes";
        // 
        // txtNotes
        // 
        this.txtNotes.Location = new System.Drawing.Point(110, 175);
        this.txtNotes.Name = "txtNotes";
        this.txtNotes.Size = new System.Drawing.Size(300, 23);
        this.txtNotes.TabIndex = 4;
        // 
        // btnSave
        // 
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Location = new System.Drawing.Point(110, 215);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(150, 30);
        this.btnSave.TabIndex = 5;
        this.btnSave.Text = "Save";
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // lblResult
        // 
        this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
        this.lblResult.Location = new System.Drawing.Point(110, 255);
        this.lblResult.Name = "lblResult";
        this.lblResult.Size = new System.Drawing.Size(300, 20);
        this.lblResult.Text = "";
        // 
        // lblRecent
        // 
        this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblRecent.Location = new System.Drawing.Point(10, 290);
        this.lblRecent.Name = "lblRecent";
        this.lblRecent.Size = new System.Drawing.Size(300, 20);
        this.lblRecent.Text = "Recent (last 30 days)";
        // 
        // dgvRecent
        // 
        this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colReference,
            this.colCode,
            this.colProduct,
            this.colChange,
            this.colUnitPrice,
            this.colTotal,
            this.colUser,
            this.colNotes});
        this.dgvRecent.AllowUserToAddRows = false;
        this.dgvRecent.AllowUserToDeleteRows = false;
        this.dgvRecent.AllowUserToResizeRows = false;
        this.dgvRecent.ReadOnly = true;
        this.dgvRecent.RowHeadersVisible = false;
        this.dgvRecent.MultiSelect = false;
        this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRecent.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvRecent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvRecent.AutoGenerateColumns = false;
        this.dgvRecent.Location = new System.Drawing.Point(10, 315);
        this.dgvRecent.Name = "dgvRecent";
        this.dgvRecent.Size = new System.Drawing.Size(880, 245);
        this.dgvRecent.TabIndex = 6;
        // 
        // colDate
        // 
        this.colDate.DataPropertyName = "Date";
        this.colDate.HeaderText = "Date";
        this.colDate.Name = "colDate";
        this.colDate.ReadOnly = true;
        style1.Format = "g";
        this.colDate.DefaultCellStyle = style1;
        // 
        // colReference
        // 
        this.colReference.DataPropertyName = "Reference";
        this.colReference.HeaderText = "Reference";
        this.colReference.Name = "colReference";
        this.colReference.ReadOnly = true;
        // 
        // colCode
        // 
        this.colCode.DataPropertyName = "Code";
        this.colCode.HeaderText = "Code";
        this.colCode.Name = "colCode";
        this.colCode.ReadOnly = true;
        // 
        // colProduct
        // 
        this.colProduct.DataPropertyName = "Product";
        this.colProduct.HeaderText = "Product";
        this.colProduct.Name = "colProduct";
        this.colProduct.ReadOnly = true;
        // 
        // colChange
        // 
        this.colChange.DataPropertyName = "Change";
        this.colChange.HeaderText = "Change";
        this.colChange.Name = "colChange";
        this.colChange.ReadOnly = true;
        // 
        // colUnitPrice
        // 
        this.colUnitPrice.DataPropertyName = "UnitPrice";
        this.colUnitPrice.HeaderText = "Unit price";
        this.colUnitPrice.Name = "colUnitPrice";
        this.colUnitPrice.ReadOnly = true;
        style2.Format = "N2";
        this.colUnitPrice.DefaultCellStyle = style2;
        // 
        // colTotal
        // 
        this.colTotal.DataPropertyName = "Total";
        this.colTotal.HeaderText = "Total";
        this.colTotal.Name = "colTotal";
        this.colTotal.ReadOnly = true;
        style3.Format = "N2";
        this.colTotal.DefaultCellStyle = style3;
        // 
        // colUser
        // 
        this.colUser.DataPropertyName = "User";
        this.colUser.HeaderText = "User";
        this.colUser.Name = "colUser";
        this.colUser.ReadOnly = true;
        // 
        // colNotes
        // 
        this.colNotes.DataPropertyName = "Notes";
        this.colNotes.HeaderText = "Notes";
        this.colNotes.Name = "colNotes";
        this.colNotes.ReadOnly = true;
        // 
        // StockForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 570);
        this.Controls.Add(this.lblProduct);
        this.Controls.Add(this.cmbProduct);
        this.Controls.Add(this.lblAvailable);
        this.Controls.Add(this.lblSupplier);
        this.Controls.Add(this.cmbSupplier);
        this.Controls.Add(this.lblQty);
        this.Controls.Add(this.numQty);
        this.Controls.Add(this.lblPrice);
        this.Controls.Add(this.numPrice);
        this.Controls.Add(this.lblNotes);
        this.Controls.Add(this.txtNotes);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblResult);
        this.Controls.Add(this.lblRecent);
        this.Controls.Add(this.dgvRecent);
        this.Name = "StockForm";
        this.Text = "Receive Stock";
        this.Load += new System.EventHandler(this.StockForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblProduct;
    private System.Windows.Forms.ComboBox cmbProduct;
    private System.Windows.Forms.Label lblAvailable;
    private System.Windows.Forms.Label lblSupplier;
    private System.Windows.Forms.ComboBox cmbSupplier;
    private System.Windows.Forms.Label lblQty;
    private System.Windows.Forms.NumericUpDown numQty;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.NumericUpDown numPrice;
    private System.Windows.Forms.Label lblNotes;
    private System.Windows.Forms.TextBox txtNotes;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Label lblRecent;
    private System.Windows.Forms.DataGridView dgvRecent;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
    private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
}

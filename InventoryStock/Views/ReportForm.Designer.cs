#nullable disable
namespace InventoryStock.Views;

partial class ReportForm
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
        this.lblReport = new System.Windows.Forms.Label();
        this.cmbReport = new System.Windows.Forms.ComboBox();
        this.lblFrom = new System.Windows.Forms.Label();
        this.dtpFrom = new System.Windows.Forms.DateTimePicker();
        this.lblTo = new System.Windows.Forms.Label();
        this.dtpTo = new System.Windows.Forms.DateTimePicker();
        this.btnRun = new System.Windows.Forms.Button();
        this.btnExport = new System.Windows.Forms.Button();
        this.lblSummary = new System.Windows.Forms.Label();
        this.dgvReport = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
        this.SuspendLayout();
        // 
        // lblReport
        // 
        this.lblReport.Location = new System.Drawing.Point(10, 13);
        this.lblReport.Name = "lblReport";
        this.lblReport.Size = new System.Drawing.Size(55, 20);
        this.lblReport.Text = "Report";
        // 
        // cmbReport
        // 
        this.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbReport.FormattingEnabled = true;
        this.cmbReport.Location = new System.Drawing.Point(70, 10);
        this.cmbReport.Name = "cmbReport";
        this.cmbReport.Size = new System.Drawing.Size(230, 23);
        this.cmbReport.TabIndex = 0;
        this.cmbReport.SelectedIndexChanged += new System.EventHandler(this.cmbReport_SelectedIndexChanged);
        // 
        // lblFrom
        // 
        this.lblFrom.Location = new System.Drawing.Point(320, 13);
        this.lblFrom.Name = "lblFrom";
        this.lblFrom.Size = new System.Drawing.Size(40, 20);
        this.lblFrom.Text = "From";
        // 
        // dtpFrom
        // 
        this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFrom.Location = new System.Drawing.Point(365, 10);
        this.dtpFrom.Name = "dtpFrom";
        this.dtpFrom.Size = new System.Drawing.Size(105, 23);
        this.dtpFrom.TabIndex = 1;
        // 
        // lblTo
        // 
        this.lblTo.Location = new System.Drawing.Point(480, 13);
        this.lblTo.Name = "lblTo";
        this.lblTo.Size = new System.Drawing.Size(25, 20);
        this.lblTo.Text = "To";
        // 
        // dtpTo
        // 
        this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpTo.Location = new System.Drawing.Point(510, 10);
        this.dtpTo.Name = "dtpTo";
        this.dtpTo.Size = new System.Drawing.Size(105, 23);
        this.dtpTo.TabIndex = 2;
        // 
        // btnRun
        // 
        this.btnRun.UseVisualStyleBackColor = true;
        this.btnRun.Location = new System.Drawing.Point(630, 7);
        this.btnRun.Name = "btnRun";
        this.btnRun.Size = new System.Drawing.Size(80, 30);
        this.btnRun.TabIndex = 3;
        this.btnRun.Text = "Run";
        this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
        // 
        // btnExport
        // 
        this.btnExport.UseVisualStyleBackColor = true;
        this.btnExport.Location = new System.Drawing.Point(720, 7);
        this.btnExport.Name = "btnExport";
        this.btnExport.Size = new System.Drawing.Size(100, 30);
        this.btnExport.TabIndex = 4;
        this.btnExport.Text = "Export CSV";
        this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
        // 
        // lblSummary
        // 
        this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblSummary.Location = new System.Drawing.Point(10, 45);
        this.lblSummary.Name = "lblSummary";
        this.lblSummary.Size = new System.Drawing.Size(900, 22);
        this.lblSummary.Text = "";
        // 
        // dgvReport
        // 
        this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
});
        this.dgvReport.AllowUserToAddRows = false;
        this.dgvReport.AllowUserToDeleteRows = false;
        this.dgvReport.AllowUserToResizeRows = false;
        this.dgvReport.ReadOnly = true;
        this.dgvReport.RowHeadersVisible = false;
        this.dgvReport.MultiSelect = false;
        this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dgvReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.dgvReport.Location = new System.Drawing.Point(10, 75);
        this.dgvReport.Name = "dgvReport";
        this.dgvReport.Size = new System.Drawing.Size(960, 475);
        this.dgvReport.TabIndex = 5;
        // 
        // ReportForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(980, 560);
        this.Controls.Add(this.lblReport);
        this.Controls.Add(this.cmbReport);
        this.Controls.Add(this.lblFrom);
        this.Controls.Add(this.dtpFrom);
        this.Controls.Add(this.lblTo);
        this.Controls.Add(this.dtpTo);
        this.Controls.Add(this.btnRun);
        this.Controls.Add(this.btnExport);
        this.Controls.Add(this.lblSummary);
        this.Controls.Add(this.dgvReport);
        this.Name = "ReportForm";
        this.Text = "Reports & History";
        this.Load += new System.EventHandler(this.ReportForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblReport;
    private System.Windows.Forms.ComboBox cmbReport;
    private System.Windows.Forms.Label lblFrom;
    private System.Windows.Forms.DateTimePicker dtpFrom;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.DateTimePicker dtpTo;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Button btnExport;
    private System.Windows.Forms.Label lblSummary;
    private System.Windows.Forms.DataGridView dgvReport;
}

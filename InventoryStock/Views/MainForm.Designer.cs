#nullable disable
namespace InventoryStock.Views;

partial class MainForm
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuCategories = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuSuppliers = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuReceive = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuAdjust = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.lblWelcome = new System.Windows.Forms.ToolStripStatusLabel();
        this.lblAlert = new System.Windows.Forms.ToolStripStatusLabel();
        this.menuStrip1.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProducts,
            this.mnuCategories,
            this.mnuSuppliers,
            this.mnuReceive,
            this.mnuSale,
            this.mnuAdjust,
            this.mnuReports,
            this.mnuAdmin,
            this.mnuLogout});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // mnuProducts
        // 
        this.mnuProducts.Name = "mnuProducts";
        this.mnuProducts.Text = "Products";
        this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
        // 
        // mnuCategories
        // 
        this.mnuCategories.Name = "mnuCategories";
        this.mnuCategories.Text = "Categories";
        this.mnuCategories.Click += new System.EventHandler(this.mnuCategories_Click);
        // 
        // mnuSuppliers
        // 
        this.mnuSuppliers.Name = "mnuSuppliers";
        this.mnuSuppliers.Text = "Suppliers";
        this.mnuSuppliers.Click += new System.EventHandler(this.mnuSuppliers_Click);
        // 
        // mnuReceive
        // 
        this.mnuReceive.Name = "mnuReceive";
        this.mnuReceive.Text = "Receive Stock";
        this.mnuReceive.Click += new System.EventHandler(this.mnuReceive_Click);
        // 
        // mnuSale
        // 
        this.mnuSale.Name = "mnuSale";
        this.mnuSale.Text = "Record Sale";
        this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
        // 
        // mnuAdjust
        // 
        this.mnuAdjust.Name = "mnuAdjust";
        this.mnuAdjust.Text = "Adjust Stock";
        this.mnuAdjust.Click += new System.EventHandler(this.mnuAdjust_Click);
        // 
        // mnuReports
        // 
        this.mnuReports.Name = "mnuReports";
        this.mnuReports.Text = "Reports && History";
        this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
        // 
        // mnuAdmin
        // 
        this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers,
            this.mnuBackup,
            this.mnuRestore});
        this.mnuAdmin.Name = "mnuAdmin";
        this.mnuAdmin.Text = "Administration";
        // 
        // mnuUsers
        // 
        this.mnuUsers.Name = "mnuUsers";
        this.mnuUsers.Text = "Users";
        this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
        // 
        // mnuBackup
        // 
        this.mnuBackup.Name = "mnuBackup";
        this.mnuBackup.Text = "Backup Database";
        this.mnuBackup.Click += new System.EventHandler(this.mnuBackup_Click);
        // 
        // mnuRestore
        // 
        this.mnuRestore.Name = "mnuRestore";
        this.mnuRestore.Text = "Restore Database";
        this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
        // 
        // mnuLogout
        // 
        this.mnuLogout.Name = "mnuLogout";
        this.mnuLogout.Text = "Logout";
        this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
        // 
        // statusStrip1
        // 
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWelcome,
            this.lblAlert});
        this.statusStrip1.Location = new System.Drawing.Point(0, 678);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
        this.statusStrip1.TabIndex = 1;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // lblWelcome
        // 
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Spring = true;
        this.lblWelcome.Text = "Logged in: (user)";
        this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblAlert
        // 
        this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAlert.Name = "lblAlert";
        this.lblAlert.Text = "Stock levels OK";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1100, 700);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.menuStrip1);
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Inventory Stock Management System";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuProducts;
    private System.Windows.Forms.ToolStripMenuItem mnuCategories;
    private System.Windows.Forms.ToolStripMenuItem mnuSuppliers;
    private System.Windows.Forms.ToolStripMenuItem mnuReceive;
    private System.Windows.Forms.ToolStripMenuItem mnuSale;
    private System.Windows.Forms.ToolStripMenuItem mnuAdjust;
    private System.Windows.Forms.ToolStripMenuItem mnuReports;
    private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
    private System.Windows.Forms.ToolStripMenuItem mnuUsers;
    private System.Windows.Forms.ToolStripMenuItem mnuBackup;
    private System.Windows.Forms.ToolStripMenuItem mnuRestore;
    private System.Windows.Forms.ToolStripMenuItem mnuLogout;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblWelcome;
    private System.Windows.Forms.ToolStripStatusLabel lblAlert;
}

#nullable disable
namespace InventoryStock.Views;

partial class LoginForm
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblUser = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.lblPass = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.lblMessage = new System.Windows.Forms.Label();
        this.lblHint = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblTitle
        // 
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.Location = new System.Drawing.Point(30, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(320, 32);
        this.lblTitle.Text = "Inventory Stock Login";
        // 
        // lblUser
        // 
        this.lblUser.Location = new System.Drawing.Point(30, 73);
        this.lblUser.Name = "lblUser";
        this.lblUser.Size = new System.Drawing.Size(100, 20);
        this.lblUser.Text = "Username/Email";
        // 
        // txtUsername
        // 
        this.txtUsername.Location = new System.Drawing.Point(130, 70);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(200, 23);
        this.txtUsername.TabIndex = 0;
        // 
        // lblPass
        // 
        this.lblPass.Location = new System.Drawing.Point(30, 108);
        this.lblPass.Name = "lblPass";
        this.lblPass.Size = new System.Drawing.Size(90, 20);
        this.lblPass.Text = "Password";
        // 
        // txtPassword
        // 
        this.txtPassword.UseSystemPasswordChar = true;
        this.txtPassword.Location = new System.Drawing.Point(130, 105);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(200, 23);
        this.txtPassword.TabIndex = 1;
        // 
        // btnLogin
        // 
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Location = new System.Drawing.Point(130, 145);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(100, 30);
        this.btnLogin.TabIndex = 2;
        this.btnLogin.Text = "Login";
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // lblMessage
        // 
        this.lblMessage.ForeColor = System.Drawing.Color.Red;
        this.lblMessage.Location = new System.Drawing.Point(30, 190);
        this.lblMessage.Name = "lblMessage";
        this.lblMessage.Size = new System.Drawing.Size(320, 36);
        this.lblMessage.Text = "";
        // 
        // lblHint
        // 
        this.lblHint.ForeColor = System.Drawing.Color.Gray;
        this.lblHint.Location = new System.Drawing.Point(30, 230);
        this.lblHint.Name = "lblHint";
        this.lblHint.Size = new System.Drawing.Size(340, 20);
        this.lblHint.Text = "Demo: admin/admin123, manager/manager123, sales/sales123";
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AcceptButton = this.btnLogin;
        this.ClientSize = new System.Drawing.Size(390, 270);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblUser);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.lblPass);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.lblMessage);
        this.Controls.Add(this.lblHint);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Name = "LoginForm";
        this.Text = "Inventory Stock - Login";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPass;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Label lblHint;
}

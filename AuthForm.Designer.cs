namespace XProtection;

partial class AuthForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnSubmit = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();

        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Sign In";

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(20, 65);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "Email:";

        // txtEmail
        this.txtEmail.Location = new System.Drawing.Point(100, 62);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(300, 25);
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);

        // lblPassword
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(20, 110);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Text = "Password:";

        // txtPassword
        this.txtPassword.Location = new System.Drawing.Point(100, 107);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(300, 25);
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtPassword.UseSystemPasswordChar = true;

        // btnSubmit
        this.btnSubmit.Location = new System.Drawing.Point(220, 160);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(90, 30);
        this.btnSubmit.Text = "OK";
        this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSubmit.ForeColor = System.Drawing.Color.Black;
        this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

        // btnCancel
        this.btnCancel.Location = new System.Drawing.Point(320, 160);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(80, 30);
        this.btnCancel.Text = "Cancel";
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.ForeColor = System.Drawing.Color.Black;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        // AuthForm
        this.ClientSize = new System.Drawing.Size(430, 215);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblPassword);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnSubmit);
        this.Controls.Add(this.btnCancel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Name = "AuthForm";
        this.Text = "XProtection";

        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.Button btnCancel;
}
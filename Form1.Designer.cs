namespace XProtection;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.btnNavAccount = new System.Windows.Forms.Button();
        this.btnNavSettings = new System.Windows.Forms.Button();
        this.btnNavVPN = new System.Windows.Forms.Button();
        this.btnNavAntivirus = new System.Windows.Forms.Button();
        this.lblSidebarTitle = new GradientLabel();
        this.pnlContent = new System.Windows.Forms.Panel();
        this.pnlAccount = new System.Windows.Forms.Panel();
        this.lblAccountStatus = new System.Windows.Forms.Label();
        this.btnSignOut = new System.Windows.Forms.Button();
        this.btnAddAnother = new System.Windows.Forms.Button();
        this.btnSignUp = new System.Windows.Forms.Button();
        this.btnSignIn = new System.Windows.Forms.Button();
        this.lblAccountTitle = new GradientLabel();
        this.pnlVPN = new System.Windows.Forms.Panel();
        this.lblVPNIP = new System.Windows.Forms.Label();
        this.lblVPNStatus = new System.Windows.Forms.Label();
        this.btnVPNConnect = new System.Windows.Forms.Button();
        this.cmbVPNServer = new System.Windows.Forms.ComboBox();
        this.lblVPNServerLabel = new System.Windows.Forms.Label();
        this.lblVPNTitle = new GradientLabel();
        this.pnlAntivirus = new System.Windows.Forms.Panel();
        this.lblStatus = new System.Windows.Forms.Label();
        this.dgvResults = new System.Windows.Forms.DataGridView();
        this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnScan = new System.Windows.Forms.Button();
        this.btnBrowse = new System.Windows.Forms.Button();
        this.txtFilePath = new System.Windows.Forms.TextBox();
        this.lblTitle = new GradientLabel();

        this.pnlSidebar.SuspendLayout();
        this.pnlContent.SuspendLayout();
        this.pnlAccount.SuspendLayout();
        this.pnlVPN.SuspendLayout();
        this.pnlAntivirus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
        this.SuspendLayout();

        // pnlSidebar
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(230, 230, 240);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Width = 200;
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Controls.Add(this.btnNavAccount);
        this.pnlSidebar.Controls.Add(this.btnNavSettings);
        this.pnlSidebar.Controls.Add(this.btnNavVPN);
        this.pnlSidebar.Controls.Add(this.btnNavAntivirus);
        this.pnlSidebar.Controls.Add(this.lblSidebarTitle);

        // lblSidebarTitle
        this.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblSidebarTitle.Height = 70;
        this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblSidebarTitle.Text = "XProtection";
        this.lblSidebarTitle.Name = "lblSidebarTitle";

        // btnNavAntivirus
        this.btnNavAntivirus.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavAntivirus.Height = 50;
        this.btnNavAntivirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavAntivirus.FlatAppearance.BorderSize = 0;
        this.btnNavAntivirus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 200, 215);
        this.btnNavAntivirus.BackColor = System.Drawing.Color.FromArgb(210, 210, 225);
        this.btnNavAntivirus.ForeColor = System.Drawing.Color.Black;
        this.btnNavAntivirus.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNavAntivirus.Text = "  Antivirus";
        this.btnNavAntivirus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavAntivirus.Name = "btnNavAntivirus";
        this.btnNavAntivirus.Click += new System.EventHandler(this.btnNavAntivirus_Click);

        // btnNavVPN
        this.btnNavVPN.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavVPN.Height = 50;
        this.btnNavVPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavVPN.FlatAppearance.BorderSize = 0;
        this.btnNavVPN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 200, 215);
        this.btnNavVPN.BackColor = System.Drawing.Color.FromArgb(225, 225, 240);
        this.btnNavVPN.ForeColor = System.Drawing.Color.Black;
        this.btnNavVPN.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNavVPN.Text = "  VPN";
        this.btnNavVPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavVPN.Name = "btnNavVPN";
        this.btnNavVPN.Click += new System.EventHandler(this.btnNavVPN_Click);

        // btnNavSettings
        this.btnNavSettings.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavSettings.Height = 50;
        this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavSettings.FlatAppearance.BorderSize = 0;
        this.btnNavSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 200, 215);
        this.btnNavSettings.BackColor = System.Drawing.Color.FromArgb(225, 225, 240);
        this.btnNavSettings.ForeColor = System.Drawing.Color.Black;
        this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNavSettings.Text = "  Settings";
        this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavSettings.Name = "btnNavSettings";
        this.btnNavSettings.Click += new System.EventHandler(this.btnNavSettings_Click);

        // btnNavAccount
        this.btnNavAccount.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavAccount.Height = 50;
        this.btnNavAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavAccount.FlatAppearance.BorderSize = 0;
        this.btnNavAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 200, 215);
        this.btnNavAccount.BackColor = System.Drawing.Color.FromArgb(225, 225, 240);
        this.btnNavAccount.ForeColor = System.Drawing.Color.Black;
        this.btnNavAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNavAccount.Text = "  Account";
        this.btnNavAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavAccount.Name = "btnNavAccount";
        this.btnNavAccount.Click += new System.EventHandler(this.btnNavAccount_Click);

        // pnlContent
        this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 248, 252);
        this.pnlContent.Name = "pnlContent";
        this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
        this.pnlContent.Controls.Add(this.pnlAccount);
        this.pnlContent.Controls.Add(this.pnlVPN);
        this.pnlContent.Controls.Add(this.pnlAntivirus);

        // pnlAntivirus
        this.pnlAntivirus.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlAntivirus.Name = "pnlAntivirus";
        this.pnlAntivirus.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.pnlAntivirus.Controls.Add(this.lblStatus);
        this.pnlAntivirus.Controls.Add(this.dgvResults);
        this.pnlAntivirus.Controls.Add(this.btnCancel);
        this.pnlAntivirus.Controls.Add(this.btnScan);
        this.pnlAntivirus.Controls.Add(this.btnBrowse);
        this.pnlAntivirus.Controls.Add(this.txtFilePath);
        this.pnlAntivirus.Controls.Add(this.lblTitle);

        // lblTitle
        this.lblTitle.AutoSize = false;
        this.lblTitle.Size = new System.Drawing.Size(400, 40);
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(25, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Antivirus Scanner";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // txtFilePath
        this.txtFilePath.Location = new System.Drawing.Point(25, 80);
        this.txtFilePath.Name = "txtFilePath";
        this.txtFilePath.Size = new System.Drawing.Size(540, 25);
        this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 10F);

        // btnBrowse
        this.btnBrowse.Location = new System.Drawing.Point(575, 79);
        this.btnBrowse.Name = "btnBrowse";
        this.btnBrowse.Size = new System.Drawing.Size(100, 28);
        this.btnBrowse.Text = "Browse...";
        this.btnBrowse.ForeColor = System.Drawing.Color.Black;
        this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

        // btnScan
        this.btnScan.Location = new System.Drawing.Point(25, 125);
        this.btnScan.Name = "btnScan";
        this.btnScan.Size = new System.Drawing.Size(140, 32);
        this.btnScan.Text = "Scan Folder";
        this.btnScan.ForeColor = System.Drawing.Color.Black;
        this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnScan.Click += new System.EventHandler(this.btnScan_Click);

        // btnCancel
        this.btnCancel.Location = new System.Drawing.Point(175, 125);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(100, 32);
        this.btnCancel.Text = "Cancel";
        this.btnCancel.ForeColor = System.Drawing.Color.Black;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.Enabled = false;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        // dgvResults
        this.dgvResults.Location = new System.Drawing.Point(25, 180);
        this.dgvResults.Name = "dgvResults";
        this.dgvResults.Size = new System.Drawing.Size(650, 320);
        this.dgvResults.AllowUserToAddRows = false;
        this.dgvResults.AllowUserToDeleteRows = false;
        this.dgvResults.ReadOnly = true;
        this.dgvResults.RowHeadersVisible = false;
        this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvResults.MultiSelect = false;
        this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvResults.BackgroundColor = System.Drawing.Color.White;
        this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.dgvResults.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFile, this.colReason, this.colHash });
        this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);

        // colFile
        this.colFile.HeaderText = "File";
        this.colFile.Name = "colFile";
        this.colFile.FillWeight = 50F;

        // colReason
        this.colReason.HeaderText = "Reason";
        this.colReason.Name = "colReason";
        this.colReason.FillWeight = 25F;

        // colHash
        this.colHash.HeaderText = "Hash";
        this.colHash.Name = "colHash";
        this.colHash.FillWeight = 25F;

        // lblStatus
        this.lblStatus.AutoSize = false;
        this.lblStatus.Location = new System.Drawing.Point(25, 515);
        this.lblStatus.Size = new System.Drawing.Size(650, 25);
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Ready.";

        // pnlVPN
        this.pnlVPN.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlVPN.Name = "pnlVPN";
        this.pnlVPN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.pnlVPN.Visible = false;
        this.pnlVPN.Controls.Add(this.lblVPNIP);
        this.pnlVPN.Controls.Add(this.lblVPNStatus);
        this.pnlVPN.Controls.Add(this.btnVPNConnect);
        this.pnlVPN.Controls.Add(this.cmbVPNServer);
        this.pnlVPN.Controls.Add(this.lblVPNServerLabel);
        this.pnlVPN.Controls.Add(this.lblVPNTitle);

        // lblVPNTitle
        this.lblVPNTitle.AutoSize = false;
        this.lblVPNTitle.Size = new System.Drawing.Size(400, 40);
        this.lblVPNTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblVPNTitle.Location = new System.Drawing.Point(25, 20);
        this.lblVPNTitle.Name = "lblVPNTitle";
        this.lblVPNTitle.Text = "XProtection VPN";
        this.lblVPNTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // lblVPNServerLabel
        this.lblVPNServerLabel.AutoSize = true;
        this.lblVPNServerLabel.Location = new System.Drawing.Point(25, 90);
        this.lblVPNServerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblVPNServerLabel.Name = "lblVPNServerLabel";
        this.lblVPNServerLabel.Text = "Server:";

        // cmbVPNServer
        this.cmbVPNServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbVPNServer.Location = new System.Drawing.Point(90, 87);
        this.cmbVPNServer.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.cmbVPNServer.Name = "cmbVPNServer";
        this.cmbVPNServer.Size = new System.Drawing.Size(240, 25);
        this.cmbVPNServer.Items.AddRange(new object[] {
            "Germany", "Netherlands", "Croatia", "US", "UK" });
        this.cmbVPNServer.SelectedIndex = 0;

        // btnVPNConnect
        this.btnVPNConnect.Location = new System.Drawing.Point(25, 135);
        this.btnVPNConnect.Name = "btnVPNConnect";
        this.btnVPNConnect.Size = new System.Drawing.Size(140, 32);
        this.btnVPNConnect.Text = "Connect";
        this.btnVPNConnect.ForeColor = System.Drawing.Color.Black;
        this.btnVPNConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnVPNConnect.Click += new System.EventHandler(this.btnVPNConnect_Click);

        // lblVPNStatus
        this.lblVPNStatus.AutoSize = true;
        this.lblVPNStatus.Location = new System.Drawing.Point(25, 190);
        this.lblVPNStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblVPNStatus.ForeColor = System.Drawing.Color.Gray;
        this.lblVPNStatus.Name = "lblVPNStatus";
        this.lblVPNStatus.Text = "Status: Disconnected";

        // lblVPNIP
        this.lblVPNIP.AutoSize = true;
        this.lblVPNIP.Location = new System.Drawing.Point(25, 215);
        this.lblVPNIP.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblVPNIP.ForeColor = System.Drawing.Color.Gray;
        this.lblVPNIP.Name = "lblVPNIP";
        this.lblVPNIP.Text = "IP: —";

        // pnlAccount
        this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlAccount.Name = "pnlAccount";
        this.pnlAccount.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.pnlAccount.Visible = false;
        this.pnlAccount.Controls.Add(this.lblAccountStatus);
        this.pnlAccount.Controls.Add(this.btnSignOut);
        this.pnlAccount.Controls.Add(this.btnAddAnother);
        this.pnlAccount.Controls.Add(this.btnSignUp);
        this.pnlAccount.Controls.Add(this.btnSignIn);
        this.pnlAccount.Controls.Add(this.lblAccountTitle);

        // lblAccountTitle
        this.lblAccountTitle.AutoSize = false;
        this.lblAccountTitle.Size = new System.Drawing.Size(400, 40);
        this.lblAccountTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblAccountTitle.Location = new System.Drawing.Point(25, 20);
        this.lblAccountTitle.Name = "lblAccountTitle";
        this.lblAccountTitle.Text = "Account";
        this.lblAccountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // lblAccountStatus
        this.lblAccountStatus.AutoSize = false;
        this.lblAccountStatus.Location = new System.Drawing.Point(25, 75);
        this.lblAccountStatus.Size = new System.Drawing.Size(600, 30);
        this.lblAccountStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.lblAccountStatus.Name = "lblAccountStatus";
        this.lblAccountStatus.Text = "Not signed in.";

        // btnSignIn
        this.btnSignIn.Location = new System.Drawing.Point(25, 120);
        this.btnSignIn.Name = "btnSignIn";
        this.btnSignIn.Size = new System.Drawing.Size(140, 35);
        this.btnSignIn.Text = "Sign In";
        this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSignIn.ForeColor = System.Drawing.Color.Black;
        this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);

        // btnSignUp
        this.btnSignUp.Location = new System.Drawing.Point(180, 120);
        this.btnSignUp.Name = "btnSignUp";
        this.btnSignUp.Size = new System.Drawing.Size(140, 35);
        this.btnSignUp.Text = "Sign Up";
        this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSignUp.ForeColor = System.Drawing.Color.Black;
        this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

        // btnAddAnother
        this.btnAddAnother.Location = new System.Drawing.Point(335, 120);
        this.btnAddAnother.Name = "btnAddAnother";
        this.btnAddAnother.Size = new System.Drawing.Size(180, 35);
        this.btnAddAnother.Text = "Add Another Account";
        this.btnAddAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAddAnother.ForeColor = System.Drawing.Color.Black;
        this.btnAddAnother.Enabled = false;
        this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);

        // btnSignOut
        this.btnSignOut.Location = new System.Drawing.Point(25, 170);
        this.btnSignOut.Name = "btnSignOut";
        this.btnSignOut.Size = new System.Drawing.Size(140, 35);
        this.btnSignOut.Text = "Sign Out";
        this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSignOut.ForeColor = System.Drawing.Color.Black;
        this.btnSignOut.Enabled = false;
        this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);

        // Form1
        this.ClientSize = new System.Drawing.Size(1000, 650);
        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.pnlSidebar);
        this.MinimumSize = new System.Drawing.Size(800, 500);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "XProtection";

        this.pnlSidebar.ResumeLayout(false);
        this.pnlContent.ResumeLayout(false);
        this.pnlAccount.ResumeLayout(false);
        this.pnlAccount.PerformLayout();
        this.pnlVPN.ResumeLayout(false);
        this.pnlVPN.PerformLayout();
        this.pnlAntivirus.ResumeLayout(false);
        this.pnlAntivirus.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlSidebar;
    private GradientLabel lblSidebarTitle;
    private System.Windows.Forms.Button btnNavAntivirus;
    private System.Windows.Forms.Button btnNavVPN;
    private System.Windows.Forms.Button btnNavSettings;
    private System.Windows.Forms.Button btnNavAccount;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.Panel pnlAntivirus;
    private System.Windows.Forms.Panel pnlVPN;
    private System.Windows.Forms.Panel pnlAccount;
    private GradientLabel lblVPNTitle;
    private System.Windows.Forms.Label lblVPNServerLabel;
    private System.Windows.Forms.ComboBox cmbVPNServer;
    private System.Windows.Forms.Button btnVPNConnect;
    private System.Windows.Forms.Label lblVPNStatus;
    private System.Windows.Forms.Label lblVPNIP;
    private GradientLabel lblTitle;
    private GradientLabel lblAccountTitle;
    private System.Windows.Forms.Label lblAccountStatus;
    private System.Windows.Forms.Button btnSignIn;
    private System.Windows.Forms.Button btnSignUp;
    private System.Windows.Forms.Button btnAddAnother;
    private System.Windows.Forms.Button btnSignOut;
    private System.Windows.Forms.TextBox txtFilePath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnScan;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.DataGridView dgvResults;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
    private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHash;
    private System.Windows.Forms.Label lblStatus;
}
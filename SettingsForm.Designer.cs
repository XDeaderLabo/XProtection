namespace XProtection;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblHeader = new System.Windows.Forms.Label();
        this.grpGradient = new System.Windows.Forms.GroupBox();
        this.btnColor2 = new System.Windows.Forms.Button();
        this.lblColor2 = new System.Windows.Forms.Label();
        this.btnColor1 = new System.Windows.Forms.Button();
        this.lblColor1 = new System.Windows.Forms.Label();
        this.grpThreshold = new System.Windows.Forms.GroupBox();
        this.lblThresholdValue = new System.Windows.Forms.Label();
        this.trackThreshold = new System.Windows.Forms.TrackBar();
        this.chkOverride = new System.Windows.Forms.CheckBox();
        this.grpExclusions = new System.Windows.Forms.GroupBox();
        this.btnRemoveExclusion = new System.Windows.Forms.Button();
        this.btnAddExclusion = new System.Windows.Forms.Button();
        this.lstExclusions = new System.Windows.Forms.ListBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();

        this.grpGradient.SuspendLayout();
        this.grpThreshold.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
        this.grpExclusions.SuspendLayout();
        this.SuspendLayout();

        // lblHeader
        this.lblHeader.AutoSize = true;
        this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblHeader.Location = new System.Drawing.Point(20, 15);
        this.lblHeader.Name = "lblHeader";
        this.lblHeader.Text = "Settings";

        // grpGradient
        this.grpGradient.Text = "Gradient Colors";
        this.grpGradient.Location = new System.Drawing.Point(20, 55);
        this.grpGradient.Size = new System.Drawing.Size(540, 90);
        this.grpGradient.Name = "grpGradient";
        this.grpGradient.Controls.Add(this.btnColor2);
        this.grpGradient.Controls.Add(this.lblColor2);
        this.grpGradient.Controls.Add(this.btnColor1);
        this.grpGradient.Controls.Add(this.lblColor1);

        // lblColor1
        this.lblColor1.AutoSize = true;
        this.lblColor1.Location = new System.Drawing.Point(15, 30);
        this.lblColor1.Text = "Color 1:";
        this.lblColor1.Name = "lblColor1";

        // btnColor1
        this.btnColor1.Location = new System.Drawing.Point(80, 25);
        this.btnColor1.Size = new System.Drawing.Size(100, 28);
        this.btnColor1.Text = "Pick...";
        this.btnColor1.Name = "btnColor1";
        this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnColor1.ForeColor = System.Drawing.Color.Black;
        this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);

        // lblColor2
        this.lblColor2.AutoSize = true;
        this.lblColor2.Location = new System.Drawing.Point(220, 30);
        this.lblColor2.Text = "Color 2:";
        this.lblColor2.Name = "lblColor2";

        // btnColor2
        this.btnColor2.Location = new System.Drawing.Point(285, 25);
        this.btnColor2.Size = new System.Drawing.Size(100, 28);
        this.btnColor2.Text = "Pick...";
        this.btnColor2.Name = "btnColor2";
        this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnColor2.ForeColor = System.Drawing.Color.Black;
        this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);

        // grpThreshold
        this.grpThreshold.Text = "Suspicion Threshold";
        this.grpThreshold.Location = new System.Drawing.Point(20, 155);
        this.grpThreshold.Size = new System.Drawing.Size(540, 110);
        this.grpThreshold.Name = "grpThreshold";
        this.grpThreshold.Controls.Add(this.lblThresholdValue);
        this.grpThreshold.Controls.Add(this.trackThreshold);
        this.grpThreshold.Controls.Add(this.chkOverride);

        // chkOverride
        this.chkOverride.AutoSize = true;
        this.chkOverride.Location = new System.Drawing.Point(15, 25);
        this.chkOverride.Text = "Override default threshold (3)";
        this.chkOverride.Name = "chkOverride";
        this.chkOverride.CheckedChanged += new System.EventHandler(this.chkOverride_CheckedChanged);

        // trackThreshold
        this.trackThreshold.Location = new System.Drawing.Point(15, 55);
        this.trackThreshold.Minimum = 1;
        this.trackThreshold.Maximum = 10;
        this.trackThreshold.TickFrequency = 1;
        this.trackThreshold.SmallChange = 1;
        this.trackThreshold.LargeChange = 1;
        this.trackThreshold.Size = new System.Drawing.Size(400, 45);
        this.trackThreshold.Name = "trackThreshold";
        this.trackThreshold.ValueChanged += new System.EventHandler(this.trackThreshold_ValueChanged);

        // lblThresholdValue
        this.lblThresholdValue.AutoSize = true;
        this.lblThresholdValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblThresholdValue.Location = new System.Drawing.Point(430, 55);
        this.lblThresholdValue.Name = "lblThresholdValue";
        this.lblThresholdValue.Text = "3";

        // grpExclusions
        this.grpExclusions.Text = "Scan Exclusions";
        this.grpExclusions.Location = new System.Drawing.Point(20, 275);
        this.grpExclusions.Size = new System.Drawing.Size(540, 180);
        this.grpExclusions.Name = "grpExclusions";
        this.grpExclusions.Controls.Add(this.btnRemoveExclusion);
        this.grpExclusions.Controls.Add(this.btnAddExclusion);
        this.grpExclusions.Controls.Add(this.lstExclusions);

        // lstExclusions
        this.lstExclusions.Location = new System.Drawing.Point(15, 25);
        this.lstExclusions.Size = new System.Drawing.Size(400, 140);
        this.lstExclusions.Name = "lstExclusions";
        this.lstExclusions.Font = new System.Drawing.Font("Segoe UI", 9F);

        // btnAddExclusion
        this.btnAddExclusion.Location = new System.Drawing.Point(430, 25);
        this.btnAddExclusion.Size = new System.Drawing.Size(95, 30);
        this.btnAddExclusion.Text = "Add Folder";
        this.btnAddExclusion.Name = "btnAddExclusion";
        this.btnAddExclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAddExclusion.ForeColor = System.Drawing.Color.Black;
        this.btnAddExclusion.Click += new System.EventHandler(this.btnAddExclusion_Click);

        // btnRemoveExclusion
        this.btnRemoveExclusion.Location = new System.Drawing.Point(430, 65);
        this.btnRemoveExclusion.Size = new System.Drawing.Size(95, 30);
        this.btnRemoveExclusion.Text = "Remove";
        this.btnRemoveExclusion.Name = "btnRemoveExclusion";
        this.btnRemoveExclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRemoveExclusion.ForeColor = System.Drawing.Color.Black;
        this.btnRemoveExclusion.Click += new System.EventHandler(this.btnRemoveExclusion_Click);

        // btnSave
        this.btnSave.Location = new System.Drawing.Point(360, 470);
        this.btnSave.Size = new System.Drawing.Size(95, 32);
        this.btnSave.Text = "Save";
        this.btnSave.Name = "btnSave";
        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSave.ForeColor = System.Drawing.Color.Black;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

        // btnCancel
        this.btnCancel.Location = new System.Drawing.Point(465, 470);
        this.btnCancel.Size = new System.Drawing.Size(95, 32);
        this.btnCancel.Text = "Cancel";
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.ForeColor = System.Drawing.Color.Black;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        // SettingsForm
        this.ClientSize = new System.Drawing.Size(580, 520);
        this.Controls.Add(this.lblHeader);
        this.Controls.Add(this.grpGradient);
        this.Controls.Add(this.grpThreshold);
        this.Controls.Add(this.grpExclusions);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnCancel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Name = "SettingsForm";
        this.Text = "XProtection — Settings";

        this.grpGradient.ResumeLayout(false);
        this.grpGradient.PerformLayout();
        this.grpThreshold.ResumeLayout(false);
        this.grpThreshold.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
        this.grpExclusions.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.GroupBox grpGradient;
    private System.Windows.Forms.Label lblColor1;
    private System.Windows.Forms.Button btnColor1;
    private System.Windows.Forms.Label lblColor2;
    private System.Windows.Forms.Button btnColor2;
    private System.Windows.Forms.GroupBox grpThreshold;
    private System.Windows.Forms.CheckBox chkOverride;
    private System.Windows.Forms.TrackBar trackThreshold;
    private System.Windows.Forms.Label lblThresholdValue;
    private System.Windows.Forms.GroupBox grpExclusions;
    private System.Windows.Forms.ListBox lstExclusions;
    private System.Windows.Forms.Button btnAddExclusion;
    private System.Windows.Forms.Button btnRemoveExclusion;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
}
namespace XProtection;

public partial class SettingsForm : Form
{
    private readonly Settings _working;

    public SettingsForm(Settings current)
    {
        InitializeComponent();

        // clone so Cancel doesn't change anything
        _working = new Settings
        {
            GradientColor1Argb = current.GradientColor1Argb,
            GradientColor2Argb = current.GradientColor2Argb,
            OverrideSuspicionThreshold = current.OverrideSuspicionThreshold,
            SuspicionThreshold = current.SuspicionThreshold,
            ExcludedPaths = new List<string>(current.ExcludedPaths),
        };

        // load values into controls
        btnColor1.BackColor = _working.GradientColor1;
        btnColor2.BackColor = _working.GradientColor2;

        chkOverride.Checked = _working.OverrideSuspicionThreshold;
        trackThreshold.Value = Math.Clamp(_working.SuspicionThreshold, trackThreshold.Minimum, trackThreshold.Maximum);
        lblThresholdValue.Text = trackThreshold.Value.ToString();
        trackThreshold.Enabled = chkOverride.Checked;

        foreach (string p in _working.ExcludedPaths) lstExclusions.Items.Add(p);
    }

    private void btnColor1_Click(object? sender, EventArgs e)
    {
        using ColorDialog dlg = new ColorDialog { Color = _working.GradientColor1, FullOpen = true };
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            _working.GradientColor1 = dlg.Color;
            btnColor1.BackColor = dlg.Color;
        }
    }

    private void btnColor2_Click(object? sender, EventArgs e)
    {
        using ColorDialog dlg = new ColorDialog { Color = _working.GradientColor2, FullOpen = true };
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            _working.GradientColor2 = dlg.Color;
            btnColor2.BackColor = dlg.Color;
        }
    }

    private void chkOverride_CheckedChanged(object? sender, EventArgs e)
    {
        trackThreshold.Enabled = chkOverride.Checked;
        _working.OverrideSuspicionThreshold = chkOverride.Checked;
    }

    private void trackThreshold_ValueChanged(object? sender, EventArgs e)
    {
        lblThresholdValue.Text = trackThreshold.Value.ToString();
        _working.SuspicionThreshold = trackThreshold.Value;
    }

    private void btnAddExclusion_Click(object? sender, EventArgs e)
    {
        using FolderBrowserDialog dlg = new FolderBrowserDialog();
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            if (!lstExclusions.Items.Contains(dlg.SelectedPath))
            {
                lstExclusions.Items.Add(dlg.SelectedPath);
                _working.ExcludedPaths.Add(dlg.SelectedPath);
            }
        }
    }

    private void btnRemoveExclusion_Click(object? sender, EventArgs e)
    {
        if (lstExclusions.SelectedIndex < 0) return;
        string? path = lstExclusions.SelectedItem?.ToString();
        if (path == null) return;

        lstExclusions.Items.RemoveAt(lstExclusions.SelectedIndex);
        _working.ExcludedPaths.Remove(path);
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        _working.Save();
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
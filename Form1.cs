using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using WinForms.Fluent;

namespace XProtection;

public partial class Form1 : Form
{
    // Real malware hashes go here as: { "sha256hex", "MalwareName" }, Empty file hashes were a placeholder.
    private readonly Dictionary<string, string> knownBadHashes = new(StringComparer.OrdinalIgnoreCase)
    {
        // WannaCry
        { "64857fd319add7579248bfb5976e4fb7b13113d5b7d846ab1fb13173824cade3", "WannaCry Ransomware" },
        { "2584e1521065e45ec3c17767c065429038fc6291c091097ea8b22c8a502c41dd", "WannaCry Ransomware" },
        { "09a46b3e1be080745a6d8d88d6b5bd351b1c7586ae0dc94d0c238ee36421cafa", "WannaCry Ransomware" },
        { "24d004a104d4d54034dbcffc2a4b19a11f39008a575aa614ea04703480b1022c", "WannaCry Ransomware" },
        { "2ca2d550e603d74dedda03156023135b38da3630cb014e3d00b1263358c5f00d", "WannaCry Ransomware" },
        { "4a468603fdcb7a2eb5770705898cf9ef37aade532a7964642ecd705a74794b79", "WannaCry Ransomware" },
        { "36a54469ad83b479acfaacd668bb2aab140253c9c8e9a58540e9c16cdd461d99", "WannaCry Ransomware" },

        // NotPetya / Petya
        { "027cc450ef5f8c5f653329641ec1fed91f694e0d229928963b30f6b0d7d3a745", "NotPetya / Petya Ransomware" },
        { "26b4699a7b9eeb16e76305d843d4ab05e94d43f3201436927e13b3ebafa90739", "NotPetya (Sample Nero V1.40.exe)" },

        // Stuxnet
        { "a01845255bdc61b610cac269a5562ad09415aaf2a1490d53d55c4c3597670803", "Stuxnet Worm" },

        // CaddyWiper
        { "801e3b6d84862163a735502f93b9663be53ccbdd7f12b0707336fecba3a829a2", "CaddyWiper" },

        // Monoxide
        { "bd764fe2f9734d5ac56933ce68df0a175bfa98dc0266ae3cd3a5c963267ea77e", "Monoxide" },

        // Emotet
        { "a50528106787ef1cacfc68a83f6d5c364b6df508d0f65fba1a9e03fc8a485c87", "Emotet Trojan" },
        { "32b402b6450c7c31721618b7afa4c71e19559e08258a6c959f22980b4e70022a", "Emotet Trojan" },
        { "b76fbc81bbb7f3108d27d9da9e2646aeb3769fba62bf7961f79306812de3486c", "Emotet Trojan" },

        // TrickBot
        { "4220cf93ab9513046ab9c79b25bb9e9daaf18041d4755c2b5de2f587a31e54a0", "TrickBot Trojan" },
        { "5b6661b43c17ad12172c4327aa4b79be8bcf1c421cb08d6bff19f7e26282e9d8", "TrickBot Trojan" },
        { "843fae67108c2580a4590e41d5986191a71fb959959e1b1d40cfab672e15cab6", "TrickBot Trojan" },

        // Ryuk
        { "3a70394c394cb59907b5798a96a582f37ce62885fadd73267df25ad680141289", "Ryuk Ransomware" },
        { "1b424c3edf0b2e241050345432731cd804b1e273fc3c470d660c66393891cccc", "Ryuk Ransomware" },

        // Mirai
        { "36cc22c942f7544ed029c96bc181a17251986ce066e99c9ed411051095c96cf7", "Mirai IoT Botnet" },
        { "cfee5c898cdaf6b80e842642d7a761e3978ef95c48522c247cfa2b7ed4a20349", "Mirai IoT Botnet" },
    };

    private static readonly string[] suspiciousMarkers = new[]
    {
        "powershell -enc",
        "powershell -e ",
        "cmd.exe /c",
        "CreateRemoteThread",
        "VirtualAllocEx",
        "WriteProcessMemory",
        "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run",
        "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run",
        "MZ",
        "eval(",
        "base64_decode",
        "FromBase64String",
    };

    private CancellationTokenSource? _scanCts;
    private Settings _settings = new();
    private AccountStore _accountStore = new();
    private string? _signedInEmail = null;

    public Form1()
    {
        InitializeComponent();

        _settings = Settings.Load();
        _accountStore = AccountStore.Load();
        ApplyGradientColors();
        RefreshAccountState();

        string markerPath = Path.Combine(AppContext.BaseDirectory, "welcome_shown.flag");
        if (!File.Exists(markerPath))
        {
            this.Load += showWelcomeMsg;
            File.WriteAllText(markerPath, "shown");
        }

        this.Acrylic(Target.TitleBar);
    }

    private void ApplyGradientColors()
    {
        lblSidebarTitle.Color1 = _settings.GradientColor1;
        lblSidebarTitle.Color2 = _settings.GradientColor2;
        lblTitle.Color1 = _settings.GradientColor1;
        lblTitle.Color2 = _settings.GradientColor2;
        lblVPNTitle.Color1 = _settings.GradientColor1;
        lblVPNTitle.Color2 = _settings.GradientColor2;
        lblAccountTitle.Color1 = _settings.GradientColor1;
        lblAccountTitle.Color2 = _settings.GradientColor2;
        lblSidebarTitle.Invalidate();
        lblTitle.Invalidate();
        lblVPNTitle.Invalidate();
        lblAccountTitle.Invalidate();
    }

    private void SetActiveNav(string which)
    {
        Color active = System.Drawing.Color.FromArgb(200, 200, 215);
        Color inactive = System.Drawing.Color.FromArgb(225, 225, 240);

        btnNavAntivirus.BackColor = which == "antivirus" ? active : inactive;
        btnNavVPN.BackColor = which == "vpn" ? active : inactive;
        btnNavSettings.BackColor = which == "settings" ? active : inactive;
        btnNavAccount.BackColor = which == "account" ? active : inactive;

        pnlAntivirus.Visible = which == "antivirus";
        pnlVPN.Visible = which == "vpn";
        pnlAccount.Visible = which == "account";
    }

    // ---------- Navigation ----------
    private void btnNavAntivirus_Click(object? sender, EventArgs e) => SetActiveNav("antivirus");
    private void btnNavVPN_Click(object? sender, EventArgs e) => SetActiveNav("vpn");
    private void btnNavAccount_Click(object? sender, EventArgs e) => SetActiveNav("account");

    private void btnNavSettings_Click(object? sender, EventArgs e)
    {
        SetActiveNav("settings");
        using SettingsForm dlg = new SettingsForm(_settings);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            _settings = Settings.Load();
            ApplyGradientColors();
        }
        SetActiveNav("antivirus");
    }

    // ---------- Accounts ----------
    private void btnSignIn_Click(object? sender, EventArgs e)
    {
        using AuthForm dlg = new AuthForm(_accountStore, AuthMode.SignIn);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.SignedInEmail != null)
        {
            _signedInEmail = dlg.SignedInEmail;
            RefreshAccountState();
        }
    }

    private void btnSignUp_Click(object? sender, EventArgs e)
    {
        using AuthForm dlg = new AuthForm(_accountStore, AuthMode.SignUp);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.SignedInEmail != null)
        {
            _signedInEmail = dlg.SignedInEmail;
            RefreshAccountState();
        }
    }

    private void btnAddAnother_Click(object? sender, EventArgs e)
    {
        btnSignIn.Enabled = true;
        btnSignUp.Enabled = true;
    }

    private void btnSignOut_Click(object? sender, EventArgs e)
    {
        _signedInEmail = null;
        RefreshAccountState();
    }

    private void RefreshAccountState()
    {
        bool signedIn = _signedInEmail != null;

        lblAccountStatus.Text = signedIn
            ? $"Signed in as {_signedInEmail}."
            : "Not signed in.";

        btnSignIn.Enabled = !signedIn;
        btnSignUp.Enabled = !signedIn;
        btnAddAnother.Enabled = signedIn;
        btnSignOut.Enabled = signedIn;
    }

    // ---------- Antivirus ----------
    private void btnBrowse_Click(object? sender, EventArgs e)
    {
        using FolderBrowserDialog dialog = new FolderBrowserDialog();
        dialog.Description = "Select a folder to scan";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            txtFilePath.Text = dialog.SelectedPath;
            lblStatus.Text = "Ready.";
        }
    }

    private async void btnScan_Click(object? sender, EventArgs e)
    {
        string folderPath = txtFilePath.Text;

        if (string.IsNullOrWhiteSpace(folderPath))
        {
            lblStatus.Text = "Please choose a folder first.";
            return;
        }

        if (!Directory.Exists(folderPath))
        {
            lblStatus.Text = "Folder not found.";
            return;
        }

        dgvResults.Rows.Clear();
        btnScan.Enabled = false;
        btnBrowse.Enabled = false;
        btnCancel.Enabled = true;
        lblStatus.Text = "Collecting files...";

        _scanCts = new CancellationTokenSource();
        CancellationToken token = _scanCts.Token;

        try
        {
            string[] files = await Task.Run(
                () => Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories).ToArray(),
                token);

            int total = files.Length;
            int done = 0;

            foreach (string file in files)
            {
                token.ThrowIfCancellationRequested();
                done++;

                bool excluded = _settings.ExcludedPaths.Any(ex =>
                    file.StartsWith(ex, StringComparison.OrdinalIgnoreCase));
                if (excluded) continue;

                lblStatus.Text = $"Scanning {done} of {total}: {Path.GetFileName(file)}";

                try
                {
                    string hash = await Task.Run(() => ComputeSha256(file), token);
                    if (knownBadHashes.TryGetValue(hash, out string? name))
                    {
                        dgvResults.Rows.Add(file, $"Hash match: {name}", hash);
                        continue;
                    }

                    int suspicion = await Task.Run(() => ComputeSuspicion(file), token);
                    if (suspicion >= _settings.EffectiveThreshold)
                    {
                        dgvResults.Rows.Add(file, $"Suspicious ({suspicion} markers)", hash);
                    }
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch
                {
                    // skip unreadable files
                }
            }

            lblStatus.Text = dgvResults.Rows.Count > 0
                ? $"Done. {dgvResults.Rows.Count} flagged out of {total} scanned."
                : $"Done. Clean — {total} files scanned.";
        }
        catch (OperationCanceledException)
        {
            lblStatus.Text = $"Cancelled after {dgvResults.Rows.Count} flags.";
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Error: " + ex.Message;
        }
        finally
        {
            btnScan.Enabled = true;
            btnBrowse.Enabled = true;
            btnCancel.Enabled = false;
            _scanCts?.Dispose();
            _scanCts = null;
        }
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        _scanCts?.Cancel();
        lblStatus.Text = "Cancelling...";
    }

    private void dgvResults_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        string? path = dgvResults.Rows[e.RowIndex].Cells[0].Value?.ToString();
        if (string.IsNullOrEmpty(path)) return;

        string? folder = Path.GetDirectoryName(path);
        if (folder == null || !Directory.Exists(folder)) return;

        Process.Start(new ProcessStartInfo
        {
            FileName = "explorer.exe",
            Arguments = $"/select,\"{path}\"",
            UseShellExecute = true
        });
    }

    private static int ComputeSuspicion(string path)
    {
        const int chunkSize = 64 * 1024;
        byte[] buffer = new byte[chunkSize];

        int bytesRead;
        using (FileStream stream = File.OpenRead(path))
        {
            bytesRead = stream.Read(buffer, 0, chunkSize);
        }

        string content = Encoding.ASCII.GetString(buffer, 0, bytesRead).ToLowerInvariant();
        string ext = Path.GetExtension(path).ToLowerInvariant();
        bool isExecutable = ext is ".exe" or ".dll" or ".sys" or ".scr" or ".com";

        int score = 0;
        foreach (string marker in suspiciousMarkers)
        {
            string lower = marker.ToLowerInvariant();
            if (lower == "mz" && isExecutable) continue;
            if (content.Contains(lower)) score++;
        }
        return score;
    }

    // ---------- VPN ----------
    private void btnVPNConnect_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Hey, it's me, the creator!\n\n" +
            "This app is STILL WIP so if you have some patience, " +
            "please wait for the full release. ;)\n\n" +
            "Contact me @ xdeaderofficialmc@proton.me\n\n" +
            "Sincerely,\n" +
            "XDeader Labo. (C) 2026",
            "XProtection VPN",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    // ---------- Welcome ----------
    private void showWelcomeMsg(object? sender, EventArgs a)
    {
        MessageBox.Show(
            "Hey, welcome to XProtection!\n" +
            "This app is the BOUNDARY of FULL protection so\n" +
            "You are welcome to use ANY apps on the sidebar,\n" +
            "We would also LOVE some developers, cuz for now, it's only me, XDeaderGames!\n\n" +
            "Forms are being made and are ABSOLUTELY open. Feel free. :)\n\n" +
            "Sincerely,\n" +
            "XDeader Labo. (C) 2026",
            "XProtection",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    // ---------- Helpers ----------
    private static string ComputeSha256(string path)
    {
        using FileStream stream = File.OpenRead(path);
        using SHA256 sha = SHA256.Create();
        byte[] hashBytes = sha.ComputeHash(stream);
        return Convert.ToHexString(hashBytes).ToLowerInvariant();
    }
}
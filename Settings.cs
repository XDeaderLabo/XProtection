using System.Drawing;
using System.Text.Json;

namespace XProtection;

public class Settings
{
    // Gradient colors
    public int GradientColor1Argb { get; set; } = Color.FromArgb(50, 100, 200).ToArgb();
    public int GradientColor2Argb { get; set; } = Color.FromArgb(230, 130, 40).ToArgb();

    // Suspicion threshold
    public bool OverrideSuspicionThreshold { get; set; } = false;
    public int SuspicionThreshold { get; set; } = 3;

    // Scan exclusions
    public List<string> ExcludedPaths { get; set; } = new();

    // ----- Convenience accessors -----
    public Color GradientColor1
    {
        get => Color.FromArgb(GradientColor1Argb);
        set => GradientColor1Argb = value.ToArgb();
    }

    public Color GradientColor2
    {
        get => Color.FromArgb(GradientColor2Argb);
        set => GradientColor2Argb = value.ToArgb();
    }

    public int EffectiveThreshold => OverrideSuspicionThreshold ? SuspicionThreshold : 3;

    // ----- Persistence -----
    private static string SettingsPath =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "XProtection",
            "settings.json");

    public static Settings Load()
    {
        try
        {
            string path = SettingsPath;
            if (!File.Exists(path)) return new Settings();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Settings>(json) ?? new Settings();
        }
        catch
        {
            return new Settings();
        }
    }

    public void Save()
    {
        try
        {
            string path = SettingsPath;
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
        catch
        {
            // swallow — settings saving shouldn't crash the app
        }
    }
}
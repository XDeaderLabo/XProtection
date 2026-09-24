using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace XProtection;

public class Account
{
    public string Email { get; set; } = "";
    public string Salt { get; set; } = "";
    public string PasswordHash { get; set; } = "";
}

public class AccountStore
{
    public List<Account> Accounts { get; set; } = new();

    private static string StorePath =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "XProtection",
            "accounts.json");

    public static AccountStore Load()
    {
        try
        {
            if (!File.Exists(StorePath)) return new AccountStore();
            string json = File.ReadAllText(StorePath);
            return JsonSerializer.Deserialize<AccountStore>(json) ?? new AccountStore();
        }
        catch
        {
            return new AccountStore();
        }
    }

    public void Save()
    {
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(StorePath)!);
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(StorePath, json);
        }
        catch { }
    }

    public bool EmailExists(string email) =>
        Accounts.Any(a => string.Equals(a.Email, email, StringComparison.OrdinalIgnoreCase));

    public Account? FindByEmail(string email) =>
        Accounts.FirstOrDefault(a => string.Equals(a.Email, email, StringComparison.OrdinalIgnoreCase));

    public void Add(string email, string password)
    {
        string salt = GenerateSalt();
        Accounts.Add(new Account
        {
            Email = email,
            Salt = salt,
            PasswordHash = HashPassword(password, salt),
        });
    }

    public bool Verify(string email, string password)
    {
        Account? acc = FindByEmail(email);
        if (acc == null) return false;
        return acc.PasswordHash == HashPassword(password, acc.Salt);
    }

    // ----- helpers -----
    private static string GenerateSalt()
    {
        byte[] bytes = RandomNumberGenerator.GetBytes(16);
        return Convert.ToBase64String(bytes);
    }

    private static string HashPassword(string password, string salt)
    {
        byte[] saltBytes = Convert.FromBase64String(salt);
        byte[] passBytes = Encoding.UTF8.GetBytes(password);

        byte[] combined = new byte[saltBytes.Length + passBytes.Length];
        Buffer.BlockCopy(saltBytes, 0, combined, 0, saltBytes.Length);
        Buffer.BlockCopy(passBytes, 0, combined, saltBytes.Length, passBytes.Length);

        byte[] hash = SHA256.HashData(combined);
        return Convert.ToBase64String(hash);
    }
}
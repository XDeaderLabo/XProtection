namespace XProtection;

public enum AuthMode { SignIn, SignUp }

public partial class AuthForm : Form
{
    private readonly AccountStore _store;
    private readonly AuthMode _mode;

    public string? SignedInEmail { get; private set; }

    public AuthForm(AccountStore store, AuthMode mode)
    {
        InitializeComponent();
        _store = store;
        _mode = mode;

        lblTitle.Text = mode == AuthMode.SignIn ? "Sign In" : "Sign Up";
        this.Text = mode == AuthMode.SignIn ? "XProtection — Sign In" : "XProtection — Sign Up";
    }

    private void btnSubmit_Click(object? sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Enter an email.", "XProtection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (password.Length < 4)
        {
            MessageBox.Show("Password must be at least 4 characters.", "XProtection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_mode == AuthMode.SignUp)
        {
            if (_store.EmailExists(email))
            {
                MessageBox.Show("This email is already registered.", "XProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _store.Add(email, password);
            _store.Save();
            SignedInEmail = email;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            if (!_store.Verify(email, password))
            {
                MessageBox.Show("Error: Email not registered or incorrect password.", "XProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SignedInEmail = email;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
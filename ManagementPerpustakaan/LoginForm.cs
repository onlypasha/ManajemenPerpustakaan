using ManagementPerpustakaan.Services;

namespace ManagementPerpustakaan;

public partial class LoginForm : Form
{
    private readonly IAuthService _authService = new AuthService();

    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
        string username = UsernameTextBox.Text;
        string password = PasswordTextBox.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Username atau password kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_authService.Login(username, password))
        {
            new Layouts.MainForm().Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void KembaliBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void LihatPasswordChk_CheckedChanged(object sender, EventArgs e)
    {
        PasswordTextBox.UseSystemPasswordChar = !LihatPasswordChk.Checked;
    }
}
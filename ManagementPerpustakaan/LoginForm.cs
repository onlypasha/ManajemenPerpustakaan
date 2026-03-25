namespace ManagementPerpustakaan;

public partial class LoginForm : Form
{
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
            MessageBox.Show("Username atau password kosong");
        }
        else
        {
            if (username == "admin" && password == "admin")
            {
                //new Admin.Dashboard().Show();
                new Layouts.MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah");
            }
        }
    }

    private void KembaliBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LihatPasswordChk_CheckedChanged(object sender, EventArgs e)
    {
        if (LihatPasswordChk.Checked)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }
        else
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
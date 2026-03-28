using ManagementPerpustakaan.UserControl.Admin;

namespace ManagementPerpustakaan.Layouts;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        this.Text = "Management Perpustakaan";
    }

    private void TampilkanHalaman(System.Windows.Forms.UserControl uc)
    {
        splitContainer1.Panel2.Controls.Clear();
        uc.Dock = DockStyle.Fill;
        splitContainer1.Panel2.Controls.Add(uc);
    }
    

    private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
    {
        switch (e.Node.Name)
        {
            case "DashboardAdmin_node":
                DashboardAdmin DashboardAdmin = new DashboardAdmin();
                TampilkanHalaman(DashboardAdmin);
                break;
            case "MBAdmin_node":
                MBAdmin ManajemenBukuAdmin = new MBAdmin();
                TampilkanHalaman(ManajemenBukuAdmin);
                break;
            default:
                MessageBox.Show("Halaman Belum Tersedia");
                break;
        }
    }

    private void Logout_btn_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        this.Close();
        loginForm.Show();
    }
}
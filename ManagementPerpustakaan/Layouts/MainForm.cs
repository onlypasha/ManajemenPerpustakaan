using ManagementPerpustakaan.UserControl.Admin;

namespace ManagementPerpustakaan.Layouts;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void TampilkanHalaman(System.Windows.Forms.UserControl uc)
    {
        splitContainer1.Panel2.Controls.Clear();
        uc.Dock = DockStyle.Fill;
        splitContainer1.Panel2.Controls.Add(uc);
    }

    private void logout_btn_Click(object sender, EventArgs e)
    {
        new LoginForm().Show();
        this.Close();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        switch (e.Node.Name)
        {
            case "DashboardAdmin_NODE":
                DashboardAdmin dashboardAdmin = new DashboardAdmin();
                TampilkanHalaman(dashboardAdmin);
                break;
            case "MBAdmin_NODE":
                MBAdmin ManajemenBukuAdmin = new MBAdmin();
                TampilkanHalaman(ManajemenBukuAdmin);
                break;
            default:
                MessageBox.Show("Halaman Belum Tersedia");
                break;
        }
    }
}
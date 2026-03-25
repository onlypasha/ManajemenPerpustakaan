using ManagementPerpustakaan.Services;
using Microsoft.Data.SqlClient;

namespace ManagementPerpustakaan.UserControl.Admin;

public partial class DashboardAdmin : System.Windows.Forms.UserControl
{
    private readonly BukuService _bukuService = new();

    public DashboardAdmin()
    {
        InitializeComponent();
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
        try
        {
            dgv_admin.DataSource = _bukuService.GetAllBuku();
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
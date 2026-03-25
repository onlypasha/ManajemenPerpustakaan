using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ManagementPerpustakaan.UserControl.Admin;

public partial class DashboardAdmin : System.Windows.Forms.UserControl
{
    public DashboardAdmin()
    {
        InitializeComponent();
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
        string query =
            "SELECT MS_Buku.id_buku, MS_Buku.judul_buku, MS_Buku.tahun_terbit, MS_Kategori.jenis_kategori FROM MS_Buku INNER JOIN MS_Kategori ON MS_Buku.id_kategori = MS_Kategori.id_kategori;";
        using (SqlConnection connection =
               new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnections"].ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable  dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                dgv_admin.DataSource = dataTable;
            }
        }
    }
}
using ManagementPerpustakaan.Services;

namespace ManagementPerpustakaan.UserControl.Admin;

public partial class DashboardAdmin : System.Windows.Forms.UserControl
{
    private readonly BukuService _bukuService = new();
    private readonly KategoriService _kategoriService = new();

    public DashboardAdmin()
    {
        InitializeComponent();
    }
    

    private void DashboardAdmin_Load(object sender, EventArgs e)
    {
        jb_label.Text = _bukuService.JumlahBuku().ToString();
        jk_label.Text = _kategoriService.JumlahKategori().ToString();
    }
}
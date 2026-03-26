using ManagementPerpustakaan.Services;
using ManagementPerpustakaan.CustomForms;

namespace ManagementPerpustakaan.UserControl.Admin;

public partial class MBAdmin : System.Windows.Forms.UserControl
{
    private readonly BukuService _bukuService = new();
    public MBAdmin()
    {
        InitializeComponent();
    }

    private void MBAdmin_Load(object sender, EventArgs e)
    {
        AllBukuGrid.DataSource = _bukuService.GetAllBuku();
    }

    private void TambahBuku_btn_Click(object sender, EventArgs e)
    {
        using (var dialog = new InsertBukuForms())
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
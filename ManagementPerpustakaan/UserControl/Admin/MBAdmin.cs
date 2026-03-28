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

        /*for (int i = 0; i < AllBukuGrid.Rows.Count; i++)
        {
            AllBukuGrid.Rows[i].Cells["No"].Value = i + 1;
        }*/
        AllBukuGrid.Columns["IdBuku"].Visible = false;
        AllBukuGrid.Columns["IdKategori"].Visible = false;
    }

    private void TambahBuku_btn_Click(object sender, EventArgs e)
    {
        using (var dialog = new InsertBukuForms())
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _bukuService.InsertBuku(dialog.BukuBaru);
                AllBukuGrid.DataSource = _bukuService.GetAllBuku();
                MessageBox.Show("Buku berhasil ditambahkan!", 
                    "Info", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }

    private void deleteMenu_Click(object sender, EventArgs e)
    {
        if (AllBukuGrid.CurrentRow != null)
        {
            string judulBuku = (string)AllBukuGrid.CurrentRow.Cells["JudulBuku"].Value;
            int idBuku = (int)AllBukuGrid.CurrentRow.Cells["IdBuku"].Value;

            DialogResult konfirmasiHapus = MessageBox.Show(
                $"Apakah anda yakin akan menghapus buku {judulBuku}?",
                "Hapus buku",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (konfirmasiHapus == DialogResult.OK)
            {
                _bukuService.DeleteBuku(idBuku);
                AllBukuGrid.DataSource = _bukuService.GetAllBuku();
                MessageBox.Show("Buku berhasil di hapus", "Info");
            }
        }
    }
}
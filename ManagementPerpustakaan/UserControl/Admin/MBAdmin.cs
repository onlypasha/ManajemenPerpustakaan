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
        RefreshGrid();
        AllBukuGrid.Columns["IdBuku"].Visible = false;
        AllBukuGrid.Columns["IdKategori"].Visible = false;
    }

    private void RefreshGrid()
    {
        AllBukuGrid.DataSource = _bukuService.GetAllBuku();
    }

    private void TambahBuku_btn_Click(object sender, EventArgs e)
    {
        using var dialog = new InsertBukuForms();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            _bukuService.InsertBuku(dialog.BukuBaru);
            RefreshGrid();
            MessageBox.Show("Buku berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void deleteMenu_Click(object sender, EventArgs e)
    {
        if (AllBukuGrid.CurrentRow == null) return;

        string judulBuku = (string)AllBukuGrid.CurrentRow.Cells["JudulBuku"].Value;
        int idBuku = (int)AllBukuGrid.CurrentRow.Cells["IdBuku"].Value;

        var result = MessageBox.Show(
            $"Apakah anda yakin akan menghapus buku \"{judulBuku}\"?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _bukuService.DeleteBuku(idBuku);
            RefreshGrid();
            MessageBox.Show("Buku berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
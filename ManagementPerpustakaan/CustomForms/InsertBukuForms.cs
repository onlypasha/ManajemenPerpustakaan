using System.Data;
using ManagementPerpustakaan.Models;
using ManagementPerpustakaan.Services;

namespace ManagementPerpustakaan.CustomForms;

public partial class InsertBukuForms : Form
{
    private readonly KategoriService _kategoriService = new ();
    private readonly BukuService _bukuService = new ();
    public InsertBukuForms()
    {
        InitializeComponent();
        this.Load += InsertBukuForms_Load;
    }

    private void InsertBukuForms_Load(object sender, EventArgs e)
    {
        Kategori_field.DataSource = _kategoriService.GetAllKategori();
        Kategori_field.DisplayMember = "JenisKategori";
        Kategori_field.ValueMember = "iDKategori";
    }

    private void Cancel_btn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    public Buku BukuBaru
    {
        get;
        private set;
    }

    private void Insert_btn_Click(object sender, EventArgs e)
    {
        BukuBaru = new Buku
        {
            JudulBuku = JudulBuku_field.Text,
            TahunTerbit = int.Parse(TahunTerbit_field.Text),
            IdKategori = Convert.ToInt32(Kategori_field.SelectedValue),
            DeskripsiBuku = Deskripsi_field.Text,
            Penulis = Penulis_field.Text,
            Status = "Tersedia",
            Stok = int.Parse(Stok_field.Text)
        };

        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
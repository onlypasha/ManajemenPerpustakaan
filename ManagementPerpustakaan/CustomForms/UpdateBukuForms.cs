using ManagementPerpustakaan.Models;
using ManagementPerpustakaan.Services;

namespace ManagementPerpustakaan.CustomForms;

public partial class UpdateBukuForms : Form
{
    private readonly BukuService _bukuService = new();
    private readonly KategoriService _kategoriService = new();
    private readonly int _idBuku;
    
    public Buku? BukuUpdate { get; private set; }

    public UpdateBukuForms(int id_buku)
    {
        _idBuku = id_buku;
        InitializeComponent();
        
        // Wire up button click event
        SimpanEdit_btn.Click += SimpanEdit_btn_Click;
    }

    private void UpdateBukuForms_Load(object sender, EventArgs e)
    {
        LoadKategori();
        LoadBukuDetails();
    }

    private void LoadKategori()
    {
        var kategori = _kategoriService.GetAllKategori();
        Kategori_field.DataSource = kategori;
        Kategori_field.DisplayMember = "JenisKategori";
        Kategori_field.ValueMember = "IdKategori";
    }

    private void LoadBukuDetails()
    {
        Buku bukuDetails = _bukuService.GetDetailBukuById(_idBuku);
        if (bukuDetails != null)
        {
            JudulBuku_field.Text = bukuDetails.JudulBuku;
            Penulis_field.Text = bukuDetails.Penulis;
            TahunTerbit_field.Text = bukuDetails.TahunTerbit.ToString();
            Kategori_field.SelectedValue = bukuDetails.IdKategori;
            Stok_field.Text = bukuDetails.Stok.ToString();
            Deskripsi_field.Text = bukuDetails.DeskripsiBuku;
        }
    }

    private void Batal_btn_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void SimpanEdit_btn_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        BukuUpdate = new Buku
        {
            IdBuku = _idBuku,
            JudulBuku = JudulBuku_field.Text.Trim(),
            TahunTerbit = int.Parse(TahunTerbit_field.Text),
            IdKategori = Convert.ToInt32(Kategori_field.SelectedValue),
            DeskripsiBuku = Deskripsi_field.Text.Trim(),
            Penulis = Penulis_field.Text.Trim(),
            Status = "Tersedia", // Defaults to Tersedia for now, or you could fetch existing status
            Stok = int.Parse(Stok_field.Text)
        };

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(JudulBuku_field.Text))
        {
            ShowWarning("Judul buku tidak boleh kosong.");
            return false;
        }

        if (!int.TryParse(TahunTerbit_field.Text, out _))
        {
            ShowWarning("Tahun terbit harus berupa angka.");
            return false;
        }

        if (!int.TryParse(Stok_field.Text, out _))
        {
            ShowWarning("Stok harus berupa angka.");
            return false;
        }

        return true;
    }

    private void ShowWarning(string message)
    {
        MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}

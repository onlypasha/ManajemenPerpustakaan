using ManagementPerpustakaan.Models;
using ManagementPerpustakaan.Services;

namespace ManagementPerpustakaan.CustomForms;

public partial class InsertBukuForms : Form
{
    private readonly KategoriService _kategoriService = new();

    public Buku? BukuBaru { get; private set; }

    public InsertBukuForms()
    {
        InitializeComponent();
    }

    private void InsertBukuForms_Load(object sender, EventArgs e)
    {
        var categories = _kategoriService.GetAllKategori();
        Kategori_field.DataSource = categories;
        Kategori_field.DisplayMember = "JenisKategori";
        Kategori_field.ValueMember = "IdKategori";
    }

    private void Cancel_btn_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void Insert_btn_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        BukuBaru = new Buku
        {
            JudulBuku = JudulBuku_field.Text.Trim(),
            TahunTerbit = int.Parse(TahunTerbit_field.Text),
            IdKategori = Convert.ToInt32(Kategori_field.SelectedValue),
            DeskripsiBuku = Deskripsi_field.Text.Trim(),
            Penulis = Penulis_field.Text.Trim(),
            Status = "Tersedia",
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
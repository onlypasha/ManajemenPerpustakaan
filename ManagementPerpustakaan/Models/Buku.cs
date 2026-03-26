namespace ManagementPerpustakaan.Models;

public class Buku
{
    public int IdBuku { get; set; }
    public string JudulBuku { get; set; } = string.Empty;
    public int TahunTerbit { get; set; }
    public int IdKategori { get; set; }
    public string DeskripsiBuku { get; set; } = string.Empty;
    public string Penulis { get; set; } = string.Empty;
    public string Status { get; set; } = "Tersedia";
    public int Stok { get; set; }
    public string JenisKategori { get; set; } = string.Empty;
}

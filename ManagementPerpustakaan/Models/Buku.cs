namespace ManagementPerpustakaan.Models;

public class Buku
{
    public int IdBuku { get; set; }
    public string JudulBuku { get; set; } = string.Empty;
    public int TahunTerbit { get; set; }
    public string JenisKategori { get; set; } = string.Empty;
}

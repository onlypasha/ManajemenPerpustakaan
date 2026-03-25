using ManagementPerpustakaan.Models;
using Microsoft.Data.SqlClient;

namespace ManagementPerpustakaan.Services;

public class BukuService
{
    /// <summary>
    /// Mengambil semua data buku beserta kategorinya dari database.
    /// </summary>
    /// <returns>List of Buku, atau list kosong jika terjadi error.</returns>
    public List<Buku> GetAllBuku()
    {
        var result = new List<Buku>();

        const string query =
            """
            SELECT MS_Buku.id_buku, MS_Buku.judul_buku, MS_Buku.tahun_terbit, MS_Kategori.jenis_kategori
            FROM MS_Buku
            INNER JOIN MS_Kategori ON MS_Buku.id_kategori = MS_Kategori.id_kategori
            """;

        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);

        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Add(new Buku
            {
                IdBuku = reader.GetInt32(0),
                JudulBuku = reader.GetString(1),
                TahunTerbit = reader.GetInt32(2),
                JenisKategori = reader.GetString(3)
            });
        }

        return result;
    }
}

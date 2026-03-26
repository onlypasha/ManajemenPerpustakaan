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
        const string query = @"
        SELECT MS_Buku.id_buku, MS_Buku.judul_buku, MS_Buku.tahun_terbit, MS_Buku.id_kategori,
               MS_Buku.deskripsi_buku, MS_Buku.penulis, MS_Buku.status, MS_Buku.stok,
               MS_Kategori.jenis_kategori
        FROM MS_Buku
        INNER JOIN MS_Kategori ON MS_Buku.id_kategori = MS_Kategori.id_kategori";

        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);

        connection.Open();
        using var reader = command.ExecuteReader();

        var result = new List<Buku>();
        while (reader.Read())
            result.Add(MapToBuku(reader));

        return result;
    }

    private static Buku MapToBuku(SqlDataReader reader)
    {
        return new Buku
        {
            IdBuku       = reader.GetInt32(reader.GetOrdinal("id_buku")),
            JudulBuku    = reader.GetStringOrEmpty("judul_buku"),
            TahunTerbit  = reader.GetInt32(reader.GetOrdinal("tahun_terbit")),
            IdKategori   = reader.GetInt32(reader.GetOrdinal("id_kategori")),
            DeskripsiBuku = reader.GetStringOrEmpty("deskripsi_buku"),
            Penulis      = reader.GetStringOrEmpty("penulis"),
            Status       = reader.GetStringOrEmpty("status"),
            Stok         = reader.GetInt32(reader.GetOrdinal("stok")),
            JenisKategori = reader.GetStringOrEmpty("jenis_kategori")
        };
    }

    public int JumlahBuku()
    {
        const string query = "SELECT COUNT(*) FROM MS_Buku";
        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);
        connection.Open();

        int jumlah = (int)command.ExecuteScalar();
        return jumlah;
    }

    public void InsertBuku(Buku buku)
    {
        const string query = @"
        INSERT INTO MS_Buku 
        (judul_buku, tahun_terbit, id_kategori, deskripsi_buku, 
         user_input, user_edit, time_input, time_edit, 
         penulis, status, stok)
        VALUES 
        (@JudulBuku, @TahunTerbit, @IdKategori, @DeskripsiBuku, 
         @UserInput, @UserEdit, @TimeInput, @TimeEdit, 
         @Penulis, @Status, @Stok)";

        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@JudulBuku", buku.JudulBuku);
        command.Parameters.AddWithValue("@TahunTerbit", buku.TahunTerbit);
        command.Parameters.AddWithValue("@IdKategori", buku.IdKategori); // ambil dari ComboBox SelectedValue
        command.Parameters.AddWithValue("@DeskripsiBuku", string.IsNullOrEmpty(buku.DeskripsiBuku) ? DBNull.Value : buku.DeskripsiBuku);
        command.Parameters.AddWithValue("@UserInput", "Admin"); // bisa ambil dari user login
        command.Parameters.AddWithValue("@UserEdit", "Admin");
        command.Parameters.AddWithValue("@TimeInput", DateTime.Now);
        command.Parameters.AddWithValue("@TimeEdit", DateTime.Now);
        command.Parameters.AddWithValue("@Penulis", buku.Penulis);
        command.Parameters.AddWithValue("@Status", buku.Status);
        command.Parameters.AddWithValue("@Stok", buku.Stok);

        connection.Open();
        command.ExecuteNonQuery();
    }
}

public static class SqlDataReaderExtensions
{
    public static string GetStringOrEmpty(this SqlDataReader reader, string columnName)
    {
        var ordinal = reader.GetOrdinal(columnName);
        return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
    }
}
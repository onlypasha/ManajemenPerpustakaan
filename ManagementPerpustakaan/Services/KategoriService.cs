using System.Data;
using ManagementPerpustakaan.Models;
using Microsoft.Data.SqlClient;

namespace ManagementPerpustakaan.Services;

public class KategoriService
{
    public List<Kategori> GetAllKategori()
    {
        var result = new List<Kategori>();
        const string query = "SELECT id_kategori, jenis_kategori FROM MS_Kategori";
        
        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Add(new Kategori
            {
                IdKategori =  reader.GetInt32(0),
                JenisKategori = reader.GetString(1),
            });
        }

        return result;
    }
    
    public int JumlahKategori()
    {
        const string query = "SELECT COUNT(*) FROM MS_Kategori";
        using var connection = new SqlConnection(DatabaseHelper.GetConnectionString());
        using var command = new SqlCommand(query, connection);
        connection.Open();

        int jumlah = (int)command.ExecuteScalar();
        return jumlah;
    }
    
}
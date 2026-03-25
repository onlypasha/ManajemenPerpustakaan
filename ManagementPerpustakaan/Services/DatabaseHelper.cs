using System.Configuration;

namespace ManagementPerpustakaan.Services;

public static class DatabaseHelper
{
    public static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["MyConnections"].ConnectionString;
    }
}

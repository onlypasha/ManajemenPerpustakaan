using Microsoft.Data.SqlClient;

namespace ManagementPerpustakaan.Extensions;

public static class SqlDataReaderExtensions
{
    public static string GetStringOrEmpty(this SqlDataReader reader, string columnName)
    {
        var ordinal = reader.GetOrdinal(columnName);
        return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
    }
}

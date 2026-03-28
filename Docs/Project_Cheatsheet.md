# 📚 Manajemen Perpustakaan Cheatsheet

Selamat datang di cheatsheet project **Manajemen Perpustakaan**. File ini dirancang untuk membantu memahami struktur kode, pola desain, dan cuplikan kode penting yang digunakan dalam project ini.

---

## 🏗️ Project Architecture

Project ini menggunakan arsitektur **N-Tier/Layered Architecture** sederhana:
- **Models**: Representasi data (Entity).
- **Services**: Logika bisnis, autentikasi, dan akses database.
- **Extensions**: Helper methods untuk meningkatkan fungsionalitas class bawaan .NET.
- **Layouts/UserControl**: Antarmuka pengguna (WinForms).
- **CustomForms**: Form tambahan untuk aksi spesifik (seperti Insert/Update).

---

## 🔐 Authentication Service

Logika login telah dipisahkan ke dalam `AuthService` untuk menjaga agar Form tetap bersih.
```csharp
// Path: ManagementPerpustakaan/Services/AuthService.cs
public interface IAuthService {
    bool Login(string username, string password);
}
```

---

## 🗄️ Database Access

Project menggunakan `Microsoft.Data.SqlClient` untuk interaksi dengan SQL Server.

### 🔗 Database Helper
Mengambil connection string dari `App.config`.
```csharp
// Path: ManagementPerpustakaan/Services/DatabaseHelper.cs
public static string GetConnectionString()
{
    return ConfigurationManager.ConnectionStrings["MyConnections"].ConnectionString;
}
```

---

## 📦 Models

### 📕 Buku
```csharp
public class Buku {
    public int IdBuku { get; set; }
    public string JudulBuku { get; set; } = string.Empty;
    public int TahunTerbit { get; set; }
    public int IdKategori { get; set; }
    public string DeskripsiBuku { get; set; } = string.Empty;
    public string Penulis { get; set; } = string.Empty;
    public string Status { get; set; } = "Tersedia";
    public int Stok { get; set; }
    public string JenisKategori { get; set; } = string.Empty; // Join Property
}
```

---

## 🛠️ Services (Logika Bisnis)

### 📖 BukuService
Berisi operasi CRUD untuk tabel `MS_Buku`.

| Method | Fungsi |
| :--- | :--- |
| `GetAllBuku()` | Mengambil semua buku dengan Join ke Kategori. |
| `JumlahBuku()` | Menghitung total buku (Scalar). |
| `InsertBuku(Buku)` | Menambah data buku baru ke database. |
| `DeleteBuku(id)` | Menghapus buku berdasarkan ID. |

---

## 💡 Tips & Trick

### 🔍 Extensions (SqlDataReader)
Digunakan untuk membaca string yang mungkin NULL dengan aman.
```csharp
// Path: ManagementPerpustakaan/Extensions/SqlDataReaderExtensions.cs
public static string GetStringOrEmpty(this SqlDataReader reader, string columnName) {
    var ordinal = reader.GetOrdinal(columnName);
    return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
}
```

### 📂 Memuat UserControl ke Panel
Pola yang sering digunakan di `MainForm`:
```csharp
private void TampilkanHalaman(UserControl uc) {
    mainPanel.Controls.Clear();
    uc.Dock = DockStyle.Fill;
    mainPanel.Controls.Add(uc);
}
```

---

## 🚀 Komponen UI Penting
- **LoginForm**: Menggunakan `IAuthService` untuk validasi.
- **MainForm**: Sidebar navigasi menggunakan `TreeView`.
- **MBAdmin**: Manajemen data buku dengan `DataGridView`.
- **InsertBukuForms**: Form popup dengan validasi input dasar.

---
*Dibuat otomatis oleh Gemini CLI - 2026*

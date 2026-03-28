namespace ManagementPerpustakaan.Services;

public interface IAuthService
{
    bool Login(string username, string password);
}

public class AuthService : IAuthService
{
    public bool Login(string username, string password)
    {
        return username == "admin" && password == "admin";
    }
}

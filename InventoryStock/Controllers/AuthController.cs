using System.Security.Cryptography;
using InventoryStock.Data;
using InventoryStock.Models;

namespace InventoryStock.Controllers;

public class AuthController
{
    // Password format: "<iterations>.<saltBase64>.<hashBase64>" (PBKDF2-SHA256, NFR02)
    private const int Iterations = 100_000;

    public static string Hash(string password)
    {
        var salt = RandomNumberGenerator.GetBytes(16);
        var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
        return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
    }

    public static bool Verify(string password, string stored)
    {
        var parts = stored.Split('.');
        if (parts.Length != 3 || !int.TryParse(parts[0], out int iter)) return false;
        var salt = Convert.FromBase64String(parts[1]);
        var expected = Convert.FromBase64String(parts[2]);
        var actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, iter, HashAlgorithmName.SHA256, expected.Length);
        return CryptographicOperations.FixedTimeEquals(actual, expected);
    }

    // FR02: log in with username OR email + password
    public User? Login(string usernameOrEmail, string password)
    {
        using var db = new AppDbContext();
        var id = usernameOrEmail.Trim().ToLower();
        var user = db.Users.FirstOrDefault(u => u.IsActive &&
                        (u.Username.ToLower() == id || u.Email.ToLower() == id));
        return user != null && Verify(password, user.PasswordHash) ? user : null;
    }

    // ---- User administration (FR01, FR14) ----
    public string Validate(User u, string password, bool isNew)
    {
        if (string.IsNullOrWhiteSpace(u.Username)) return "Username is required.";
        if (string.IsNullOrWhiteSpace(u.FullName)) return "Full name is required.";
        if (string.IsNullOrWhiteSpace(u.Email) || !u.Email.Contains('@')) return "A valid email is required.";
        if (!Roles.All.Contains(u.Role)) return "Choose a role.";
        if (isNew && password.Length < 6) return "Password must be at least 6 characters.";
        if (!isNew && password.Length > 0 && password.Length < 6) return "Password must be at least 6 characters.";

        using var db = new AppDbContext();
        string name = u.Username.ToLower(), mail = u.Email.ToLower();
        if (db.Users.Any(x => x.UserId != u.UserId && x.Username.ToLower() == name)) return "Username already exists.";
        if (db.Users.Any(x => x.UserId != u.UserId && x.Email.ToLower() == mail)) return "Email already in use.";
        return "";
    }

    public List<UserRow> GetAll()
    {
        using var db = new AppDbContext();
        return db.Users.OrderBy(u => u.UserId).Select(u => new UserRow
        {
            Id = u.UserId, Username = u.Username, FullName = u.FullName,
            Email = u.Email, Role = u.Role, Active = u.IsActive
        }).ToList();
    }

    public User? Get(int id)
    {
        using var db = new AppDbContext();
        return db.Users.Find(id);
    }

    public void Add(User u, string password)
    {
        using var db = new AppDbContext();
        u.PasswordHash = Hash(password);
        db.Users.Add(u);
        db.SaveChanges();
    }

    // password "" keeps the existing one
    public string Update(User u, string password)
    {
        using var db = new AppDbContext();
        var x = db.Users.Find(u.UserId);
        if (x == null) return "User not found.";

        // never lock the system out of its last active administrator
        bool losesAdmin = x.Role == Roles.Administrator && x.IsActive && (u.Role != Roles.Administrator || !u.IsActive);
        if (losesAdmin && db.Users.Count(a => a.Role == Roles.Administrator && a.IsActive) <= 1)
            return "There must be at least one active administrator.";

        x.Username = u.Username; x.FullName = u.FullName; x.Email = u.Email;
        x.Role = u.Role; x.IsActive = u.IsActive;
        if (password.Length > 0) x.PasswordHash = Hash(password);
        db.SaveChanges();
        return "";
    }
}

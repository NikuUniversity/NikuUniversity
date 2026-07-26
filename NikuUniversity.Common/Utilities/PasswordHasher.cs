using System.Security.Cryptography;

namespace NikuUniversity.Common.Utilities;

public static class PasswordHasher
{
    private const int SaltSize = 16; // 128-bit salt
    private const int KeySize = 32;  // 256-bit subkey
    private const int Iterations = 100_000; // PBKDF2 iterations
    private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA256;

    /// <summary>
    /// Hashes a plain-text password using PBKDF2 with salt.
    /// </summary>
    public static string HashPassword(string password)
    {
        Guard.AgainstNullOrEmpty(password, nameof(password));

        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, Algorithm, KeySize);

        // Store salt and hash together as base64 string formatted: {iterations}.{salt}.{hash}
        return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
    }

    /// <summary>
    /// Verifies a plain-text password against a hashed password string.
    /// </summary>
    public static bool VerifyPassword(string password, string hashedPassword)
    {
        if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hashedPassword))
            return false;

        var parts = hashedPassword.Split('.');
        if (parts.Length != 3)
            return false;

        int iterations = int.Parse(parts[0]);
        byte[] salt = Convert.FromBase64String(parts[1]);
        byte[] storedHash = Convert.FromBase64String(parts[2]);

        byte[] computedHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, Algorithm, storedHash.Length);

        return CryptographicOperations.FixedTimeEquals(computedHash, storedHash);
    }
}
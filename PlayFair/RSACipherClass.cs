using System.Security.Cryptography;
using System.Text;

public class RSACipherClass
{
    private RSA rsa;

    public RSACipherClass()
    {
        rsa = RSA.Create();
    }

    // Phương thức tạo khóa công khai và khóa riêng
    public void GenerateKeys()
    {
        rsa = RSA.Create(2048); // Tạo khóa 2048 bit (có thể thay đổi tùy theo yêu cầu)
    }

    // Phương thức mã hóa với khóa công khai
    public string EncryptWithPublicKey(string plaintext, string publicKey)
    {
        rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKey), out _);
        byte[] data = Encoding.UTF8.GetBytes(plaintext);
        byte[] encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
        return Convert.ToBase64String(encryptedData);
    }

    // Phương thức giải mã với khóa riêng
    public string DecryptWithPrivateKey(string ciphertext, string privateKey)
    {
        rsa.ImportRSAPrivateKey(Convert.FromBase64String(privateKey), out _);
        byte[] encryptedData = Convert.FromBase64String(ciphertext);
        byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
        return Encoding.UTF8.GetString(decryptedData);
    }

    // Phương thức xuất khóa công khai
    public string ExportPublicKey()
    {
        return Convert.ToBase64String(rsa.ExportRSAPublicKey());
    }

    // Phương thức xuất khóa riêng
    public string ExportPrivateKey()
    {
        return Convert.ToBase64String(rsa.ExportRSAPrivateKey());
    }
}

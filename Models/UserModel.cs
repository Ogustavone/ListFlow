using static BCrypt.Net.BCrypt;

namespace ListFlow.Models
{
    public class UserModel(string name, string pass) : BaseEntity
    {
        private readonly string _password = GetEncryptedPassword(pass);
        public string Name { get; set; } = name;
        public string Password { get => _password; }

        private static string GetEncryptedPassword(string strPassword)
        {
            string passwordHash = HashPassword(strPassword);
            return passwordHash;
        }

        public bool ValidatePassword(string strPassword)
        {
            return Verify(strPassword, _password);
        }
    }
}
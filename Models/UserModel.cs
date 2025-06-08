using static BCrypt.Net.BCrypt;

namespace ListFlow.Models
{
    public class UserModel : BaseEntity
    {
        public UserModel() { }

        public UserModel(string name, string pass)
        {
            Name = name;
            Password = GetEncryptedPassword(pass);
        }

        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        private static string GetEncryptedPassword(string strPassword)
        {
            return HashPassword(strPassword);
        }

        public bool ValidatePassword(string strPassword)
        {
            return Verify(strPassword, Password);
        }
    }
}
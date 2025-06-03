using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace ListFlow.Models
{
    public class UserModel : BaseEntity
    {
        private string _passwordHash = string.Empty;

        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Password
        {
            get
            {
                return _passwordHash;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Erro: A senha não pode receber um valor nulo ou vazio.");
                }
                _passwordHash = GetPasswordHash(value);
            }
        }

        public string GetPasswordHash(string cleanPassword)
        {
            return HashPassword(cleanPassword, 12);
        }

        public bool PasswordHashIsValid(string cleanPassword, string hashedPassword)
        {
            return Verify(cleanPassword, hashedPassword);
        }
    }
}
// using BCrypt.Net;
// using static BCrypt.Net.BCrypt;

namespace ListFlow.Models
{
    public class UserModel : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        //TODO: retornar hash com BCrypt
        // metodos GetPasswordHash e VerifyPassword
    }
}
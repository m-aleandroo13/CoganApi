using CoganApi.Models;

namespace CoganApi.Dtos
{
    public class AuthenticateResponseDto
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string UserLevel { get; set; }
        private readonly UserManagement _user;

        public AuthenticateResponseDto(UserManagement user, string token)
        {
            FullName = user.FullName;
            Username = user.Username;
            Token = token;
            UserLevel = user.User_Level;
            _user = user;

        }

        public UserManagement GetUser()
        {
            return _user;
        }
    }
}

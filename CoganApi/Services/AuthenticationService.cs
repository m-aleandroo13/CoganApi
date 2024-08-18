using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;
using CoganApi.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoganApi.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserManagementRepository _userManagementRepository;
        private readonly IConfiguration _config;
        private readonly IUserAuditRepository _userAudit;

        public AuthenticationService(IUserManagementRepository userManagementRepository, IConfiguration config, IUserAuditRepository userAudit)
        {
            _userManagementRepository = userManagementRepository;
            _config = config;
            _userAudit = userAudit;
        }

        public AuthenticateResponseDto Authenticate(AuthenticateRequestDto model)
        {
            var user = _userManagementRepository.GetUserByName(model.Username);

            // return null if user not found
            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.Password)) return null;
            if (user.Status.ToLower() == "deactive") return null;

            // update Last Login Time
            UserAuditRequestDto userAuditDto = new UserAuditRequestDto() 
            {
                Activity = "Login",
                Username = user.Username,
                Module = "Users"
            };
            var updateLastLogin = _userAudit.UpdateActivity(userAuditDto);
            if (updateLastLogin == null) return null;

            // authentication successful so generate jwt token
            var token = SaveSession(user);
            return new AuthenticateResponseDto(user, token);
        }

        private string SaveSession(UserManagement user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                new Claim(ClaimTypes.UserData, user.Username),
                new Claim(ClaimTypes.NameIdentifier, user.FullName),
                new Claim(ClaimTypes.Role, user.User_Level)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],
              claims,
              expires: DateTime.Now.AddDays(1),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

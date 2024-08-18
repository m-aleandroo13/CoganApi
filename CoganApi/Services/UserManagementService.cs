using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;
using CoganApi.Services.Interfaces;

namespace CoganApi.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserManagementRepository _userManagementRepository;

        public UserManagementService(IUserManagementRepository userManagementRepository)
        {
            _userManagementRepository = userManagementRepository;
        }
        public object CreateUser(UserManagementDto user)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user!.Password);
            UserManagement newUser = new UserManagement()
            {
                FullName = user!.FullName,
                Username = user!.Username,
                Password = hashedPassword,
                Address = user?.Address ?? string.Empty,
                Phone = user?.Phone ?? string.Empty,
                Email = user?.Email ?? string.Empty,
                Job_Title = user!.JobTitle,
                User_Level = user!.UserLevel,
                Status = user!.Status,
                Created_At = DateTime.UtcNow,
                Updated_At = DateTime.UtcNow,
                Last_Updated_By = user!.LastUpdatedBy,
            };
            var result = new
            {
                NewUser = _userManagementRepository.CreateUser(newUser),
                CreateBy = newUser.Last_Updated_By
            };
            return result;
        }

        public object DeactiveUser(int id)
        {
            throw new NotImplementedException();
        }

        public object DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserManagement GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUsersSearch(string? name, string? username, string? address, string? phone, string? email, string? jobTitle, string? userLevel)
        {
            throw new NotImplementedException();
        }

        public object UpdateUser(UserManagementDto user)
        {
            throw new NotImplementedException();
        }
    }
}

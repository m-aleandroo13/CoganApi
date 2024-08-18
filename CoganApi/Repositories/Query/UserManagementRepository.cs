using CoganApi.DBSettings;
using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;

namespace CoganApi.Repositories.Query
{
    public class UserManagementRepository : IUserManagementRepository
    {
        private readonly MyDbContext _userManagementRepository;

        public UserManagementRepository(MyDbContext context)
        {
            _userManagementRepository = context;
        }
        public UserManagement CreateUser(UserManagement user)
        {
            var newUser = _userManagementRepository.UserManagement.Add(user);
            _userManagementRepository.SaveChanges();
            return user;
        }

        public UserManagement DeactiveUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserManagement GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUserByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUserByJobTitle(string jobTitle)
        {
            throw new NotImplementedException();
        }

        public UserManagement GetUserByName(string username)
        {
            var user = _userManagementRepository.UserManagement.FirstOrDefault(u => u.Username == username);
            return user;
        }

        public IEnumerable<UserManagement> GetUserByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUserByUserLevel(string userLevel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserManagement> GetUsers()
        {
            throw new NotImplementedException();
        }

        public UserManagement UpdateUser(UserManagement user)
        {
            throw new NotImplementedException();
        }
    }
}

using CoganApi.Dtos;
using CoganApi.Models;

namespace CoganApi.Repositories.Interfaces
{
    public interface IUserManagementRepository
    {
        IEnumerable<UserManagement> GetUsers();
        UserManagement GetUser(int id);
        UserManagement GetUserByName(string username);
        IEnumerable<UserManagement> GetUserByAddress(string address);
        IEnumerable<UserManagement> GetUserByEmail(string email);
        IEnumerable<UserManagement> GetUserByPhone(string phone);
        IEnumerable<UserManagement> GetUserByJobTitle(string jobTitle);
        IEnumerable<UserManagement> GetUserByUserLevel(string userLevel);
        UserManagement CreateUser(UserManagement user);
        UserManagement UpdateUser(UserManagement user);
        UserManagement DeactiveUser(int id);
        bool DeleteUser(int id);
        
    }
}

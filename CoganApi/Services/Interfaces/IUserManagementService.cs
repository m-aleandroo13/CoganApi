using CoganApi.Dtos;
using CoganApi.Models;

namespace CoganApi.Services.Interfaces
{
    public interface IUserManagementService
    {
        IEnumerable<UserManagement> GetUsers();
        UserManagement GetUser(string id);
        IEnumerable<UserManagement> GetUsersSearch(string? name, string? username, string? address, string? phone, string? email, string? jobTitle, string? userLevel);
        Object CreateUser(UserManagementDto user);
        Object UpdateUser(UserManagementDto user);
        Object DeactiveUser(int id);
        Object DeleteUser(int id);
    }
}

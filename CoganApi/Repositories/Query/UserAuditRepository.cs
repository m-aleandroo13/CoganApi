using CoganApi.DBSettings;
using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;

namespace CoganApi.Repositories.Query
{
    public class UserAuditRepository:IUserAuditRepository
    {
        private readonly MyDbContext _dbContext;
        private readonly IUserManagementRepository _userManagementRepository;
        public UserAuditRepository(MyDbContext dbContext , IUserManagementRepository userManagementRepository)
        {
            _dbContext = dbContext;
            _userManagementRepository = userManagementRepository;
        }

        public UserAuditResponseDto UpdateActivity(UserAuditRequestDto userAuditRequest)
        {
            UserAudit userAudit = new UserAudit()
            {
                Id_User = _userManagementRepository.GetUserByName(userAuditRequest.Username).Id,
                Activity = userAuditRequest.Activity,
                Module = userAuditRequest.Module,
                DateTime = DateTime.Now
            };
            UserAuditResponseDto result = new UserAuditResponseDto()
            {
                ActionTime = DateTime.Now,
                Description = userAuditRequest.Activity,
                Username = userAuditRequest.Username
            };
            _dbContext.UserAudit.Add(userAudit);
            _dbContext.SaveChanges();
            return result;
        }
    }
}

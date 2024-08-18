using CoganApi.Dtos;

namespace CoganApi.Repositories.Interfaces
{
    public interface IUserAuditRepository
    {
        UserAuditResponseDto UpdateActivity(UserAuditRequestDto userAuditRequest);
    }
}

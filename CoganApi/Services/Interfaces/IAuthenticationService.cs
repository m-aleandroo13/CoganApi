using CoganApi.Dtos;

namespace CoganApi.Services.Interfaces
{
    public interface IAuthenticationService
    {
        AuthenticateResponseDto Authenticate(AuthenticateRequestDto model);
    }
}

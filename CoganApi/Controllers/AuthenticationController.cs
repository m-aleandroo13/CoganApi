using CoganApi.Dtos;
using CoganApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoganApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticateRequestDto requestDto)
        {
            try
            {
                var user = _authenticationService.Authenticate(requestDto);
                if (user == null)
                {
                    return BadRequest(new AllResponsesDto
                    {
                        IsSuccess = false,
                        Message = "Failed to login, please try again"
                    });
                }

                return Ok(new AllResponsesDto
                {
                    IsSuccess = true,
                    Data = user,
                    Message = "Login Success"
                });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new AllResponsesDto
                {
                    IsSuccess = false,
                    Message = "Login Failed, please contact administrator.\n{ex.Message}"
                });
            }

        }
        
    }
}

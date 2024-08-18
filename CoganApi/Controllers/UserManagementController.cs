using CoganApi.Dtos;
using CoganApi.Services;
using CoganApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoganApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserManagementService _userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userManagementService.GetUsers());
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new AllResponsesDto
                {
                    IsSuccess = false,
                    Message = "Failed to get users."
                });
            }
            
        }

        [HttpPost]
        public IActionResult Post([FromQuery] UserManagementDto user)
        {
            try
            {
                var newUser = _userManagementService.CreateUser(user);
                return Ok(new AllResponsesDto
                {
                    IsSuccess = true,
                    Data = newUser,
                    Message = "Item successfully inserted."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new AllResponsesDto
                {
                    IsSuccess = false,
                    Message = $"User failed to insert.\n{ex.Message}"
                });
            }
        }
    }
}

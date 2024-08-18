using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoganApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemServices _itemServices;
        public ItemController(IItemServices itemServices)
        {
            _itemServices = itemServices;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            try
            {
                var items = _itemServices.GetItems();
                return Ok(new AllResponsesDto
                {
                    IsSuccess = true,
                    Data = items,
                    Message = "Successfully retrieved item data."
                });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new AllResponsesDto
                {
                    IsSuccess = false,
                    Message = "Failed to get items."
                });
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromQuery] ItemsDto items)
        {
            try
            {
                var item = _itemServices.InsertItem(items);
                return Ok(new AllResponsesDto
                {
                    IsSuccess = true,
                    Data = item,
                    Message = "Item successfully inserted."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new AllResponsesDto
                {
                    IsSuccess = false,
                    Message = $"Item failed to insert.\n{ex.Message}"
                });
            }
        }
    }
}

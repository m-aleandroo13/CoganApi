using System.ComponentModel.DataAnnotations;

namespace CoganApi.Dtos
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string Username { get; init; }

        [Required]
        public string Password { get; set; }
    }
}

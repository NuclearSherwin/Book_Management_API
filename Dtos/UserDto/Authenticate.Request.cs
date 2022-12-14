using System.ComponentModel.DataAnnotations;

namespace BookManagement.Dtos.UserDto;

public class AuthenticateRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
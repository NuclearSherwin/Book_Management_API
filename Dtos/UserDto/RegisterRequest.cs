using System.ComponentModel.DataAnnotations;
using BookManagement.Models;

namespace BookManagement.Dtos.UserDto;

public class RegisterRequest
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Username { get; set; }
        
    [Required]
    public Role Role { get; set; }

    [Required]
    public string Password { get; set; }
}
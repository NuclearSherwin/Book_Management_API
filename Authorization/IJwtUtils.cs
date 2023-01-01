using BookManagement.Models;

namespace BookManagement.Authorization;

public interface IJwtUtils
{
    public string GenerateToken(User user);
    public int? ValidateToken(string token);
}
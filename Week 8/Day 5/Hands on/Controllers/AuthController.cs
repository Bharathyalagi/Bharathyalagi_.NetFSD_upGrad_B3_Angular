using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication8._5.Models;

namespace WebApplication8._5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private static List<User> users = new List<User>();
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        users.Add(user);
        return Ok(user);
    }

    [HttpPost("login")]
    public IActionResult Login(User user)
    {
        var u = users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);

        if (u == null)
        {
            _logger.LogWarning("Invalid login attempt");
            return Unauthorized();
        }

        _logger.LogInformation("User logged in");

        var token = GenerateToken(u);
        return Ok(new { token });
    }

    private string GenerateToken(User user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("THIS_IS_SECRET_KEY"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
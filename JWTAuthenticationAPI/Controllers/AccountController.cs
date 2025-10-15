using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTAuthenticationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController(IConfiguration _config) : ControllerBase
    {

        private static ConcurrentDictionary<string, string> UserData { get; set; } = new ConcurrentDictionary<string, string>();
          
        [HttpPost("login/{email}/{password}")]
        public async Task<IActionResult> Login(string email, string password)
        {
            await Task.Delay(500);        //0.5 sec delay
            var getEmail = UserData!.Keys.Where(e => e.Equals(email)).FirstOrDefault();

            if (!string.IsNullOrEmpty(getEmail))
            {
                UserData.TryGetValue(getEmail, out string? dbPassword);

                if (Equals(dbPassword, password))
                {
                    string jwttoken = GenerateJSONWebToken(getEmail);
                    return Ok(new { UserName = email, Password = password, Token= jwttoken, Message = "User login successfully." });
                }
                else
                {
                    return NotFound(new { Message = "Invalid credentails" });
                }

            }
            return NotFound(new { Message = "Email not found" });
        }

        private string GenerateJSONWebToken(string getEmail)
        {
            var jwtkey = Encoding.UTF8.GetBytes(_config["Authentication:Key"]!);
            var securitykey = new SymmetricSecurityKey(jwtkey);
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, getEmail!),
            };

            var jwttoken = new JwtSecurityToken(
                issuer: _config["Authentication:Issuer"],
                audience: _config["Authentication:Audience"],
                claims: claims,
                expires: null,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwttoken);
        }

        [HttpPost("register/{email}/{password}")]
        public async Task<IActionResult> Register(string email, string password)
        {
            await Task.Delay(500);              //0.5 sec delay
            var getEmail = UserData!.Keys.Where(e => e.Equals(email)).FirstOrDefault();

            if (!string.IsNullOrEmpty(getEmail))
            {
                return BadRequest(new { UserName = email, Password = password, Message = "User already exists." } );
            }

            UserData[email] = password;

            return Ok(new { UserName = email, Password = password, Message = "User registered successfully." } );
        }

    }
}

using JWTAuthenticationAPI.Models;
using JWTAuthenticationAPI.Services;
using Microsoft.AspNetCore.Authorization;
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
    public class AccountController : ControllerBase
    {

        #region Dependency Inject using Interface
        private readonly JWTAuthentication _JWTAuth;
        
        public AccountController(JWTAuthentication JWTAuth)
        {
            _JWTAuth = JWTAuth;
        }
        #endregion


        private static ConcurrentDictionary<string, string> UserData { get; set; } = new ConcurrentDictionary<string, string>();

        [AllowAnonymous]
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
                    TokenInfo jwttoken = _JWTAuth.GenerateJSONWebToken(getEmail);
                    return Ok(new { UserName = email, Password = password, AccessToken= jwttoken.AccessToken, AccessTokenExpiry=jwttoken.AccessTokenExpiry, Message = "User login successfully." });
                }
                else
                {
                    return NotFound(new { Message = "Invalid credentails" });
                }

            }
            return NotFound(new { Message = "Email not found" });
        }

        //private TokenDetails GenerateJSONWebToken(string getEmail)
        //{
        //    var tokenkey = Encoding.UTF8.GetBytes(_config["JwtConfig:Key"]!);
        //    var tokenissuer = _config["JwtConfig:Issuer"]!;
        //    var tokenaudience = _config["JwtConfig:Audience"]!;
        //    var tokenvaliditymins = _config.GetValue<int>("JwtConfig:TokenValidityMins");
        //    var tokenexpirytimestamp= DateTime.UtcNow.AddMinutes(tokenvaliditymins);

        //    var tokensecuritykey = new SymmetricSecurityKey(tokenkey);
        //    var tokencredentials = new SigningCredentials(tokensecuritykey, SecurityAlgorithms.HmacSha256);

        //    var tokendescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[]
        //        {
        //            new Claim(JwtRegisteredClaimNames.Email, getEmail),
        //        }),
        //        Expires = tokenexpirytimestamp,
        //        Issuer = tokenissuer,
        //        Audience =tokenaudience,
        //        SigningCredentials = tokencredentials
        //    };            

        //    var jwttokenhandler = new JwtSecurityTokenHandler();
        //    var jwtsecuritytoken = jwttokenhandler.CreateToken(tokendescriptor);
        //    var jwtaccesstoken = jwttokenhandler.WriteToken(jwtsecuritytoken);

        //    return  new TokenDetails { AccessToken = jwtaccesstoken, AccessTokenExpiry = tokenexpirytimestamp } ;
        //}

        [AllowAnonymous]
        [HttpPost("register/{email}/{password}")]
        public async Task<IActionResult> Register(string email, string password)
        {
            await Task.Delay(500);              //0.5 sec delay
            var getEmail = UserData!.Keys.Where(e => e.Equals(email)).FirstOrDefault();

            if (!string.IsNullOrEmpty(getEmail))
            {
                //UserData.Clear();
                return BadRequest(new { UserName = email, Password = password, Message = "User already exists." } );
            }

            UserData[email] = password;

            return Ok(new { UserName = email, Password = password, Message = "User registered successfully." } );
        }


        [Authorize]
        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            await Task.Delay(0);        //0.5 sec delay            

            if (UserData != null && UserData.Count > 0)
            {
                var firstUser = UserData.First();
                return Ok(new { UserName = firstUser.Key, UserPassword = firstUser.Value });
            }
            return NotFound(new { Message = "Users not found" });

        }

    }
}

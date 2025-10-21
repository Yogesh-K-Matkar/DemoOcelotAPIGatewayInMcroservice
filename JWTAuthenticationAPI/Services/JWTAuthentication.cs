using JWTAuthenticationAPI.Models;
using System.Security.Principal;
using System.Text;

namespace JWTAuthenticationAPI.Services
{
    public class JWTAuthentication(IConfiguration _config)
    {   
        #region Generate JSON Web Token      

        public TokenInfo GenerateJSONWebToken(string claimName)
        {
            var tokenkey = Encoding.UTF8.GetBytes(_config["JwtConfig:Key"]!);
            var tokenissuer = _config["JwtConfig:Issuer"]!;
            var tokenaudience = _config["JwtConfig:Audience"]!;
            var tokenvaliditymins = _config.GetValue<int>("JwtConfig:TokenValidityMins");
            var tokenexpirytimestamp = DateTime.Now.AddMinutes(tokenvaliditymins);
            var tokensecuritykey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(tokenkey);
            var tokencredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(tokensecuritykey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256);
            var tokendescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, claimName)
                }),
                Expires = tokenexpirytimestamp,
                Issuer = tokenissuer,
                Audience = tokenaudience,
                SigningCredentials = tokencredentials
            };
            var tokenhandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var securitytoken = tokenhandler.CreateToken(tokendescriptor);
            var jwttoken = tokenhandler.WriteToken(securitytoken);

            return new TokenInfo { AccessToken = jwttoken, AccessTokenExpiry=tokenexpirytimestamp };
        }
        #endregion 

    }
}

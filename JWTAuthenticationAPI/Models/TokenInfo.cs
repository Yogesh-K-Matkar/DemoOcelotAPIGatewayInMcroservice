namespace JWTAuthenticationAPI.Models
{
    public class TokenInfo
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiry { get; set; }
    }
    
}

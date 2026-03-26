using DotNet_API_27.Entities.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace DotNet_API_27.Helper
{
    public class JwtHelper(IConfiguration configuration) : IJwtHelper
    {
        public string GenerateToken(User user)
        {
            var claim = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["AppSettings:"]!));

            var creds = 
        }
    }
}

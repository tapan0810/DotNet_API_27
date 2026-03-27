using DotNet_API_27.Entities.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
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

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var toeknDescriptor = new JwtSecurityToken(
                
                issuer: configuration.GetValue<string>("AppSettings:Issuer"),
                audience: configuration.GetValue<string>("AppSettings:Audience"),
                claims: claim,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds 
                );

            return new JwtSecurityTokenHandler().WriteToken(toeknDescriptor);   
        }
    }
}

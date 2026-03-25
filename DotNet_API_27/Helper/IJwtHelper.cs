using DotNet_API_27.Entities.Models;

namespace DotNet_API_27.Helper
{
    public interface IJwtHelper
    {
        public string GenerateToken(User user);
    }
}

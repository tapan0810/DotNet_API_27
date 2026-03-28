using DotNet_API_27.Entities.DTOs.UserDTO;

namespace DotNet_API_27.Service
{
    public interface IAuthService
    {
        Task<string> Register(RegisterUserDto dto);
        Task<string> Login(LoginUserDto dto);
    }
}
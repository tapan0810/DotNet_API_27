using DotNet_API_27.Entities.DTOs.UserDTO;
using DotNet_API_27.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_27.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto dto)
            => Ok(await _service.Register(dto));

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto dto)
            => Ok(await _service.Login(dto));
    }
}
using BCrypt.Net;
using DotNet_API_27.Data;
using DotNet_API_27.Entities.DTOs.UserDTO;
using DotNet_API_27.Entities.Models;
using DotNet_API_27.Helper;
using DotNet_API_27.Service;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_27.Service
{
    public class AuthService : IAuthService
    {
        private readonly ClassDbContext _context;
        private readonly IJwtHelper _jwt;

        public AuthService(ClassDbContext context, IJwtHelper jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        public async Task<string> Register(RegisterUserDto dto)
        {
            var userExists = await _context.Users
                .AnyAsync(x => x.UserName == dto.UserName);

            if (userExists)
                return "User already exists";

            var user = new User
            {
                UserName = dto.UserName,
                HashPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return "User Registered";
        }

        public async Task<string> Login(LoginUserDto dto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.UserName == dto.UserName);

            if (user == null)
                return "Invalid Credentials";

            bool isValid = BCrypt.Net.BCrypt.Verify(dto.Password, user.HashPassword);

            if (!isValid)
                return "Invalid Credentials";

            return _jwt.GenerateToken(user);
        }
    }
}
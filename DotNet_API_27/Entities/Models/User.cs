namespace DotNet_API_27.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string HashPassword { get; set; } = string.Empty;
    }
}

namespace DotNet_API_27.Entities.DTOs.ClassDTO
{
    public class UpdateClassDTO
    {
        public string ClassName { get; set; } = string.Empty;
        public char Section { get; set; } = 'A';
        public bool IsClass { get; set; } = false;
    }
}

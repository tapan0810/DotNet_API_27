namespace DotNet_API_27.Entities.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public char Section {  get; set; } = 'A';
        public bool IsClass { get; set; } = false;

    }
}

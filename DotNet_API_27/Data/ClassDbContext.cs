using DotNet_API_27.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_27.Data
{
    public class ClassDbContext:DbContext
    {
        public ClassDbContext(DbContextOptions<ClassDbContext> options) : base(options) { }

        public DbSet<Class> Classes => Set<Class>();
    }
}

using Microsoft.EntityFrameworkCore;

namespace Core.Model.EFDbContext
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Classes> Classes { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
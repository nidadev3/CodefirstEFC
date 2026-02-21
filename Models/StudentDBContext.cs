using Microsoft.EntityFrameworkCore;

namespace CodefirstEFC.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CodefirstEFC.Models
{
    public class StudentDBContextFactory : IDesignTimeDbContextFactory<StudentDBContext>
    {
        public StudentDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentDBContext>();

            // Use your connection string here directly
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodeFirstDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

            return new StudentDBContext(optionsBuilder.Options);
        }
    }
}

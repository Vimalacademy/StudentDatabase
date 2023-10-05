using System.Data.Entity;

namespace StudentDatabase
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}

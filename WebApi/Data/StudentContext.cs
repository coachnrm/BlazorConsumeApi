using Microsoft.EntityFrameworkCore;
using ViewModel;

namespace WebApi.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {

        }
        public DbSet<Student> Student {get; set;}
    }
}
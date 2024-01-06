using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    //DbContext is our translater between model and database
    public class SQliteDbContext:DbContext
    {
        public SQliteDbContext(DbContextOptions<SQliteDbContext> options) : base(options) {
        
        }
        public DbSet<Student>? Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}

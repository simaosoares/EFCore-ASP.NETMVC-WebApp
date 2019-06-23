using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    /// <summary>
    /// The main class that coordinates Entity Framework functionality for a given data model is the database context class. 
    /// You create this class by deriving from the Microsoft.EntityFrameworkCore.DbContext class. 
    /// In your code you specify which entities are included in the data model.
    /// 
    /// This code creates a DbSet property for each entity set. In Entity Framework terminology, an entity set 
    /// typically corresponds to a database table, and an entity corresponds to a row in the table.
    /// 
    /// DbSet<Enrollment> and DbSet<Course> statements could've omitted and it would work the same. 
    /// The Entity Framework would include them implicitly because the Student entity references the Enrollment 
    /// entity and the Enrollment entity references the Course entity.
    /// </summary>
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// When the database is created, EF creates tables that have names the same as the DbSet property names. 
        /// Property names for collections are typically plural (Students rather than Student), but developers disagree 
        /// about whether table names should be pluralized or not. 
        /// The following implementation will override the default behavior by specifying singular table names in the DbContext.        
        /// </summary>        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
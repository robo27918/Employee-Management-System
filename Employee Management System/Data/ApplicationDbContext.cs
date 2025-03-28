using Microsoft.EntityFrameworkCore;
using Employee_Management_System.Models;
namespace Employee_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options){}
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<Department>().HasData(
                new Department {ID=1,Name="IT" });
            
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle {ID=1,Title="Software Engineer" }
           );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee { 
                    EmployeeId = 1, 
                    FirstName = "John", 
                    LastName = "Doe", 
                    Position = "IT Director",
                    Salary = 50000,
                    DepartmentID = 1,
                    JobTitleID=1, 
                    }


            );
        }

    }
}

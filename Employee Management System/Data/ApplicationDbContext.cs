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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FirstName = "John", LastName = "Doe", Position = "IT Director", Department = "IT", Salary = 50000 },
                new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Smith", Position = "Software Engineer", Department = "IT", Salary = 70000 },
                new Employee { EmployeeId = 3, FirstName = "Samuel", LastName = "Johnson", Position = "HR Manager", Department = "Human Resources", Salary = 60000 },
                new Employee { EmployeeId = 4, FirstName = "Olivia", LastName = "Martinez", Position = "Project Manager", Department = "Operations", Salary = 75000 },
                new Employee { EmployeeId = 5, FirstName = "Liam", LastName = "Brown", Position = "Marketing Specialist", Department = "Marketing", Salary = 55000 },
                new Employee { EmployeeId = 6, FirstName = "Emily", LastName = "Wilson", Position = "Sales Executive", Department = "Sales", Salary = 65000 },
                new Employee { EmployeeId = 7, FirstName = "Michael", LastName = "Davis", Position = "Product Designer", Department = "Design", Salary = 72000 }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department {ID=1,name="Information Technology" });
            
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle {ID=1,Title="Software Engineer" }
           );
        }

    }
}

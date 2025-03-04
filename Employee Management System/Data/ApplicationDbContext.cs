﻿using Microsoft.EntityFrameworkCore;
using Employee_Management_System.Models;
namespace Employee_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options){}
        public DbSet<Employee>Employees { get; set; }
    
    }
}

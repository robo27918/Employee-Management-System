﻿// <auto-generated />
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Employee_Management_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250312230337_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Employee_Management_System.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Department = "IT",
                            FirstName = "John",
                            LastName = "Doe",
                            Position = "IT Director",
                            Salary = 50000m
                        },
                        new
                        {
                            EmployeeId = 2,
                            Department = "IT",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Position = "Software Engineer",
                            Salary = 70000m
                        },
                        new
                        {
                            EmployeeId = 3,
                            Department = "Human Resources",
                            FirstName = "Samuel",
                            LastName = "Johnson",
                            Position = "HR Manager",
                            Salary = 60000m
                        },
                        new
                        {
                            EmployeeId = 4,
                            Department = "Operations",
                            FirstName = "Olivia",
                            LastName = "Martinez",
                            Position = "Project Manager",
                            Salary = 75000m
                        },
                        new
                        {
                            EmployeeId = 5,
                            Department = "Marketing",
                            FirstName = "Liam",
                            LastName = "Brown",
                            Position = "Marketing Specialist",
                            Salary = 55000m
                        },
                        new
                        {
                            EmployeeId = 6,
                            Department = "Sales",
                            FirstName = "Emily",
                            LastName = "Wilson",
                            Position = "Sales Executive",
                            Salary = 65000m
                        },
                        new
                        {
                            EmployeeId = 7,
                            Department = "Design",
                            FirstName = "Michael",
                            LastName = "Davis",
                            Position = "Product Designer",
                            Salary = 72000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

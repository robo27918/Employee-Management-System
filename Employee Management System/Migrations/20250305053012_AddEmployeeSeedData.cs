using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employee_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Department", "FirstName", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "IT", "John", "Doe", "IT Director", 50000m },
                    { 2, "IT", "Jane", "Smith", "Software Engineer", 70000m },
                    { 3, "Human Resources", "Samuel", "Johnson", "HR Manager", 60000m },
                    { 4, "Operations", "Olivia", "Martinez", "Project Manager", 75000m },
                    { 5, "Marketing", "Liam", "Brown", "Marketing Specialist", 55000m },
                    { 6, "Sales", "Emily", "Wilson", "Sales Executive", 65000m },
                    { 7, "Design", "Michael", "Davis", "Product Designer", 72000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);
        }
    }
}

namespace Employee_Management_System.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
      
        
        //Foreign keys
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public int JobTitleID { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}

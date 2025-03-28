using Microsoft.Identity.Client;

namespace Employee_Management_System.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Navigation property 
        public List <Employee> Employees { get; set; }


    }
}

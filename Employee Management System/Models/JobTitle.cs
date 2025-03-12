namespace Employee_Management_System.Models
{
    public class JobTitle
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //Navigation property
        public List<Employee> employees { get; set; }

    }
}

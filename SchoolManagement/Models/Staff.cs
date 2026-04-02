namespace SchoolManagement.Models
{
    public class Staff : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateOnly HireDate { get; set; }

        public override string GetRole()
        {
            return "Staff";
        }
    }
}

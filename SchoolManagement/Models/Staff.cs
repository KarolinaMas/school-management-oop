namespace SchoolManagement.Models
{
    public class Staff : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; } = string.Empty;
        public double Salary { get; set; }
        public DateOnly HireDate { get; set; }

        public override string GetRole()
        {
            return "Staff";
        }

        public override string GetProfile()
        {
            return $"Name: {FirstName}\nLast name: {LastName}\nBirthday: {Birthday}\nEmail: {Email}\n"
                + $"Employee id: {EmployeeId}\nDepartment: {Department}\nSalary: {Salary}\nHire date: {HireDate}";
        }

        public override string GetContactInfo()
        {
            return $"Email: {base.GetContactInfo()}, department: {Department}"; // base.GetContactInfo() grazins Email property
        }
    }
}

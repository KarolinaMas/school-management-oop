namespace SchoolManagement.Models
{
    public class Staff : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; } = string.Empty;
        public decimal Salary { get; set; }
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
            return $"{base.GetContactInfo()}, Department: {Department}";
        }

        public virtual decimal CalculateAnnualBonus()
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var yearDiff = today.Year - HireDate.Year;

            if (
                today.Month < HireDate.Month
                || today.Month == HireDate.Month && today.Day < HireDate.Day
            )
            {
                yearDiff--;
            }

            var totalYearsForBonus = yearDiff / 5;

            decimal totalBonusPercent = totalYearsForBonus * 5;

            return CalculateBonusAmount(totalBonusPercent);
        }

        protected decimal CalculateBonusAmount(decimal percentIndex)
        {
            return Salary * percentIndex / 100m;
        }
    }
}

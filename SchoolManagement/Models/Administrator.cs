namespace SchoolManagement.Models
{
    public class Administrator : Staff
    {
        public string Office { get; set; } = string.Empty;
        public List<string> Responsibilities { get; set; } = new();

        public Administrator(int employeeId, string firstName, string lastName, string office)
            : base(employeeId, firstName, lastName)
        {
            Office = office;
        }

        public override string GetRole()
        {
            return "Administrator";
        }

        public override string GetProfile()
        {
            return $"{base.GetProfile()}\nOffice: {Office}\nResponsibilities: {string.Join(", ", Responsibilities)}";
        }

        public override decimal CalculateAnnualBonus()
        {
            return base.CalculateAnnualBonus() + 500m;
        }
    }
}

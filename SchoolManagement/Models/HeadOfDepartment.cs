namespace SchoolManagement.Models
{
    public class HeadOfDepartment : Teacher
    {
        public int TeamSize { get; set; }
        public string DepartmentVision { get; set; } = string.Empty;

        public override string GetRole()
        {
            return "Head of department";
        }

        public HeadOfDepartment(
            int employeeId,
            string firstName,
            string lastName,
            string subjectArea,
            int teamSize
        )
            : base(employeeId, firstName, lastName, subjectArea)
        {
            TeamSize = teamSize;
        }

        public override string GetProfile()
        {
            return $"{base.GetProfile()}\nTeam size: {TeamSize}\nDepartment vision: {DepartmentVision}";
        }

        public override string GetContactInfo()
        {
            return $"{base.GetContactInfo()}, Head of department";
        }

        public override decimal CalculateAnnualBonus()
        {
            var result = base.CalculateAnnualBonus();
            return result + CalculateBonusAmount(15m);
        }
    }
}

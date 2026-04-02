namespace SchoolManagement.Models
{
    public class UndergraduateStudent : Student
    {
        public string Major { get; set; } = string.Empty;
        public string Minor { get; set; } = string.Empty;
        public int TotalCredits { get; set; }

        public override string GetRole()
        {
            return "Undergraduate student";
        }

        public override string GetProfile()
        {
            return base.GetProfile()
                + $"\nMajor: {Major}\nMinor: {Minor}\nTotal Credits: {TotalCredits}";
        }

        public override string GetAcademicStanding()
        {
            string gpaStanding = base.GetAcademicStanding();

            string yearStanding = TotalCredits switch
            {
                < 30 => "Freshman",
                < 60 => "Sophomore",
                < 90 => "Junior",
                _ => "Senior",
            };

            return $"{yearStanding}, {gpaStanding}";
        }
    }
}

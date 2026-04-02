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
    }
}

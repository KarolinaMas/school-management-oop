namespace SchoolManagement.Models
{
    public class UndergraduateStudent : Student
    {
        public string Major { get; set; }
        public string Minor { get; set; }
        public int TotalCredits { get; set; }
    }
}

namespace SchoolManagement.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Program { get; set; }
        public int GPA { get; set; }
        public int EnrollmentYear { get; set; }
    }
}

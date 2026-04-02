namespace SchoolManagement.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Program { get; set; }
        public double GPA { get; set; }
        public int EnrollmentYear { get; set; }

        public override string GetRole()
        {
            return "Student.";
        }

        public override string GetProfile()
        {
            return $"Name: {FirstName}\nLast name: {LastName}\nBirthday: {Birthday}\nEmail: {Email}\n"
                + $"Student id: {StudentId}\nProgram: {Program}\nGPA: {GPA}\nEnrollment year: {EnrollmentYear}";
        }

        public virtual string GetAcademicStanding()
        {
            return GPA switch
            {
                >= 9 => "Dean's List",
                >= 7 => "Good Standing",
                >= 5 => "Satisfactory",
                _ => "Academic Probation",
            };
        }
    }
}

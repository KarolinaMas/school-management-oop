namespace SchoolManagement.Models
{
    public class GraduateStudent : Student
    {
        public string ThesisTitle { get; set; } = string.Empty;
        public string Supervisor { get; set; } = string.Empty;
        public bool ThesisSubmitted { get; set; }

        public GraduateStudent(int studentId, string firstName, string lastName, string thesisTitle)
            : base(studentId, firstName, lastName)
        {
            ThesisTitle = thesisTitle;
        }

        public override string GetRole()
        {
            return "Graduate student";
        }

        public override string GetProfile()
        {
            return $"{base.GetProfile()}\nThesis tilte: {ThesisTitle}\nSupervisor: {Supervisor}\nThesis Submitted: {ThesisSubmitted}";
        }

        public override string GetAcademicStanding()
        {
            return GPA switch
            {
                >= 9 => "Distinction",
                >= 7 => "Merit",
                >= 5 => "Pass",
                _ => "At Risk",
            };
        }
    }
}

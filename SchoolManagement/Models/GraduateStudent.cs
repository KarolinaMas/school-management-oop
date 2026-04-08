namespace SchoolManagement.Models
{
    public class GraduateStudent : Student
    {
        public string ThesisTitle { get; set; } = string.Empty;
        public string Supervisor { get; set; } = string.Empty;
        public bool ThesisSubmitted { get; set; }

        public override string GetRole()
        {
            return "Graduate student";
        }

        public override string GetProfile()
        {
            return $"{base.GetProfile()}\n Thesis tilte: {ThesisTitle}\n Supervisor: {Supervisor}\n Thesis Submitted: {ThesisSubmitted}";
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

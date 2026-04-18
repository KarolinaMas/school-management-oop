namespace SchoolManagement.Models
{
    public class Teacher : Staff
    {
        public string SubjectArea { get; set; } = string.Empty;
        public List<string> CoursesTaught { get; set; } = new();
        public double TeachingRating { get; set; }

        public Teacher(int employeeId, string firstName, string lastName, string subjectArea)
            : base(employeeId, firstName, lastName)
        {
            SubjectArea = subjectArea;
        }

        public string GetListValues()
        {
            return string.Join(", ", CoursesTaught);
        }

        public override string GetRole()
        {
            return "Teacher";
        }

        public override string GetProfile()
        {
            return $"{base.GetProfile()}\nSubject area: {(string.IsNullOrWhiteSpace(SubjectArea) ? "N/A" : SubjectArea)}\nCourses Taught: {(CoursesTaught.Count == 0 ? "N/A" : GetListValues())}\nTeaching rating: {(TeachingRating == default ? "N/A" : TeachingRating)}";
        }

        public override decimal CalculateAnnualBonus()
        {
            var result = base.CalculateAnnualBonus();

            if (TeachingRating >= 4.5)
            {
                return result + CalculateBonusAmount(10m);
            }
            else
            {
                return result;
            }
        }
    }
}

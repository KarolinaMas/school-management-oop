namespace SchoolManagement.Models
{
    public class Teacher : Staff
    {
        public string SubjectArea { get; set; } = string.Empty;
        public List<string> CoursesTaught { get; set; } = new();
        public double TeachingRating { get; set; }

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
            return $"{base.GetProfile()}\nSubject area: {SubjectArea}\nCourses Taught: {GetListValues()}\nTeaching rating: {TeachingRating}";
        }

        public override decimal CalculateAnnualBonus()
        {
            var result = base.CalculateAnnualBonus();

            if (TeachingRating >= 4.5)
            {
                return result + (decimal)Salary * 10m / 100m;
            }
            else
            {
                return result;
            }
        }
    }
}

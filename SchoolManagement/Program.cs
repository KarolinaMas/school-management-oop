using SchoolManagement.Models;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var underStudent = new UndergraduateStudent(1, "John", "Doe", "Computer science");
            var gradStudent = new GraduateStudent(1, "Jane", "Doe", "AI programming");
            var teacher = new Teacher(3, "Stephen", "Hawking", "Physics");
            var departmentHead = new HeadOfDepartment(1, "Petras", "Petraitis", "Mathematics", 3);
            var admin = new Administrator(5, "Ona", "Onaite", "23B");
        }
    }
}

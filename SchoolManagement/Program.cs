using SchoolManagement.Models;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schoolList = new List<Person>()
            {
                new UndergraduateStudent(1, "John", "Doe", "Computer science"),
                new GraduateStudent(1, "Jane", "Doe", "AI programming"),
                new Teacher(3, "Stephen", "Hawking", "Physics"),
                new HeadOfDepartment(1, "Petras", "Petraitis", "Mathematics", 3),
                new Administrator(5, "Ona", "Onaite", "23B"),
            };

            var staffList1 = new List<Staff>()
            {
                new Teacher(4, "Albert", "Einstein", "Physics")
                {
                    Salary = 1600m,
                    HireDate = new DateOnly(2022, 2, 2),
                },
                new HeadOfDepartment(7, "Paulius", "Paulaitis", "Biology", 6)
                {
                    Salary = 2500m,
                    HireDate = new DateOnly(2016, 2, 2),
                },
                new Administrator(8, "Elton", "John", "25A")
                {
                    Salary = 3000m,
                    HireDate = new DateOnly(2021, 2, 2),
                },
            };

            var studentList = new List<Student>()
            {
                new UndergraduateStudent(9, "Jonas", "Jonaitis", "AI engineering")
                {
                    GPA = 7,
                    TotalCredits = 60,
                },
                new GraduateStudent(10, "Jessica", "Shy", "Music industry") { GPA = 9 },
            };

            // GetPersonInfo(schoolList);

            // GetStaffInfo(staffList1);

            // GetStudentInfo(studentList);
        }

        static void GetPersonInfo(List<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine("Person profile info:");
                Console.WriteLine(person.GetProfile());
                Console.WriteLine("//////////////////////");
            }
        }

        static void GetStaffInfo(List<Staff> staffList)
        {
            foreach (var member in staffList)
            {
                Console.WriteLine("Staff member info:");
                Console.WriteLine($"First name: {member.FirstName}");
                Console.WriteLine($"Role: {member.GetRole()}");
                Console.WriteLine($"Anual bonus: {member.CalculateAnnualBonus()}");
                Console.WriteLine("//////////////////////");
            }
        }

        static void GetStudentInfo(List<Student> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine("Student info:");
                Console.WriteLine($"First name: {student.FirstName}");
                Console.WriteLine($"GPA: {student.GPA}");
                Console.WriteLine($"Academic standing: {student.GetAcademicStanding()}");
                Console.WriteLine("//////////////////////");
            }
        }
    }
}

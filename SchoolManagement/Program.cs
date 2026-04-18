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

            foreach (var person in schoolList)
            {
                Console.WriteLine("Person profile info:");
                Console.WriteLine(person.GetProfile());
                Console.WriteLine("//////////////////////");
            }
        }
    }
}

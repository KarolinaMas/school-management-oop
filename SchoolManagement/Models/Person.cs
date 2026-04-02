namespace SchoolManagement.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string Email { get; set; } = string.Empty;

        public abstract string GetRole();

        public abstract string GetProfile();

        public virtual string GetContactInfo()
        {
            return Email;
        }
    }
}

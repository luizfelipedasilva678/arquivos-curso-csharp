namespace EXERCISE_LINQ.Entities
{
    class Emplyee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Emplyee(string name, double salary, string email)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}

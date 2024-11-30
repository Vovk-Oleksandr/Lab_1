using System;

namespace Task_3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double CalculateSalary()
        {
            double baseSalary = Position switch
            {
                "junior" => 10000,
                "middle" => 20000,
                "senior" => 30000,
                _ => 0
            };

            return baseSalary + Experience * 1000;
        }

        public double CalculateTax()
        {
            return CalculateSalary() * 0.2; // податок 20%
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ім'я:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введіть прізвище:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введіть посаду (junior, middle, senior):");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть стаж:");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName)
            {
                Position = position,
                Experience = experience
            };

            Console.WriteLine($"Співробітник: {employee.FirstName} {employee.LastName}, посада: {employee.Position}");
            Console.WriteLine($"Оклад: {employee.CalculateSalary():F2} грн, Податок: {employee.CalculateTax():F2} грн");
        }
    }
}

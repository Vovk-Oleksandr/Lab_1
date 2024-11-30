using System;

namespace Task_4
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfForm { get; } = DateTime.Now; //  Поле “дата заповнення анкети” має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни.

        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Введіть логін:");
            user.Login = Console.ReadLine();

            Console.WriteLine("Введіть ім'я:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Введіть прізвище:");
            user.LastName = Console.ReadLine();

            Console.WriteLine("Введіть вік:");
            user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nКористувач: {user.Login}");
            Console.WriteLine($"Ім'я: {user.FirstName} {user.LastName}");
            Console.WriteLine($"Вік: {user.Age}");
            Console.WriteLine($"Дата заповнення анкети: {user.DateOfForm}");
        }
    }
}

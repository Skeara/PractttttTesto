using System;

namespace praktika
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"имя: {FirstName} {LastName}");
            Console.WriteLine($"почта: {Email}");
            Console.WriteLine($"возраст: {Age}");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        private void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"разность: {result}");
        }

        public void ShowSubtraction(int a, int b)
        {
            Subtract(a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                FirstName = "иван",
                LastName = "иванов",
                Email = "ivan@mail.com",
                Password = "12345",
                Age = 25
            };

            user1.ShowInfo();

            Calculator calc = new Calculator();
            int sum = calc.Add(10, 5);
            Console.WriteLine($"сумма: {sum}");

            calc.ShowSubtraction(10, 5);
        }
    }
}

namespace Praktika
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public double Balance { get; private set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            Balance = 0.0;
        }

        public void AddBalance(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"баланс пополнен на {amount}. текущий баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("ошибка: сумма только положительная");
            }
        }

        private bool CheckPassword(string inputPassword)
        {
            return inputPassword == Password;
        }

        public bool Login(string inputPassword)
        {
            if (CheckPassword(inputPassword))
            {
                Console.WriteLine($"прювет, {Username}!");
                return true;
            }
            else
            {
                Console.WriteLine("не тот");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Skeara", "support@mozimer.ru", "12345");

            while (true)
            {
                Console.Write("скажи пароль: ");
                string inputPassword = Console.ReadLine();

                if (user.Login(inputPassword))
                    break;
            }

            Console.Write("\nсумма для пополнения баланса: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            user.AddBalance(amount);
        }
    }
}


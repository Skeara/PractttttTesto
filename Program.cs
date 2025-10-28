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
                Console.WriteLine($"баланс пополнен на {amount}₽. текущий баланс: {Balance}₽");
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

        public void Login(string inputPassword)
        {
            if (CheckPassword(inputPassword))
                Console.WriteLine($"прювет, {Username}!");
            else
                Console.WriteLine("неверный пароль");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Skeara", "support@mozimer.ru", "12345");

            user.Login("wrong");
            user.Login("12345");

            user.AddBalance(500);
            user.AddBalance(-100);
        }
    }
}


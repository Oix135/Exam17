namespace Exam17
{
    public enum AccountType { Обычный, Зарплатный }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new();

            Console.ForegroundColor = ConsoleColor.Yellow;

            var account = new Account { Type = AccountType.Обычный, Balance = rand.Next(500,1500) };

            Calculator.CalculateInterest(account);

            Console.WriteLine($"Баланс: {account.Balance}");

            Console.WriteLine($"Процентная ставка: {account.Interest}");


            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;

            account = new Account { Type = AccountType.Зарплатный, Balance = rand.Next(500, 1500) };

            Calculator.CalculateInterest(account);

            Console.WriteLine($"Баланс: {account.Balance}");

            Console.WriteLine($"Процентная ставка: {account.Interest}");

            Console.ForegroundColor = ConsoleColor.White;


            Console.ReadKey();
        }
    }
}

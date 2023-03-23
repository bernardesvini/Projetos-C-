using System.Globalization;

namespace ExerciciosSecao4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema bancário");
            Console.ReadLine();
            Console.Clear();


            Console.Clear();
            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string accountName = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");

            double accountDeposity;

            if (Console.ReadLine() == "s")
            {

                Console.WriteLine("Entre o valor do depósito: ");
                accountDeposity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            else
                accountDeposity = 0.00;

            Account account = new Account(accountNumber, accountName, accountDeposity);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com o valor do deposito: ");
            account.Deposity(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account.ToString());
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre com o valor para saque: ");
            account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account.ToString());
            Console.ReadLine();

        }

    }
}

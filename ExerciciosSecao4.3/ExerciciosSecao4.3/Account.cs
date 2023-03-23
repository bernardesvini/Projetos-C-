using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosSecao4._3
{
    internal class Account
    {
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
        }

        public Account(int accountNumber, string accountName, double balance) : this(accountNumber, accountName)
        {
            Deposity(balance); // é melhor, porque a logica do deposito fica no metodo, entao tambem se aplica ao deposito inicial, no caso o Saldo.
        }

        public void Deposity(double deposity)
        {
            Balance += deposity;
        }

        public void Withdraw(double withdraw)
        {
            Balance -= withdraw;
            Balance -= (double)5;
        }

        public override string ToString()
        {
            return "Conta: " + AccountNumber + "\nTitular: " + AccountName + "\nSaldo: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

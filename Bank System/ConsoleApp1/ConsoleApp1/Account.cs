using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string Owner { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string owner, double balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }
        public void deposit (double ammount)
        {
            Balance += ammount;
        }
        public void withdraw (double ammount)
        {
            Balance -= ammount + 5.0;
        }

        public override string ToString()
        {
            return "Account: "
                + AccountNumber
                + ", Owner:"
                + Owner
                + ", Balance: US$ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);        }
    }
}

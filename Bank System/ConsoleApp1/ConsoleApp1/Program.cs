using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;
            Console.Write("Enter the account number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the account owner:");
            string name = Console.ReadLine();
            Console.Write("Is there any initial fund?(y/n):");
            char answer = char.Parse(Console.ReadLine());
            if (answer=='y' || answer == 'Y'){
                Console.WriteLine("Enter the initial fund please:");
                double fund = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                account = new Account(number, name, fund);
            }
            else
            {
                account = new Account(number, name,0);

            }

            Console.WriteLine();
            Console.WriteLine("Account Details:");
            Console.WriteLine(account);

            Console.WriteLine("Enter the ammount of the deposit: ");
            double ammount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.deposit(ammount);
            Console.WriteLine("Updated account info:");
            Console.WriteLine(account);

            Console.WriteLine("Enter the ammount of the withdraw: ");
            double with = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.withdraw(with);
            Console.WriteLine("Updated account info:");
            Console.WriteLine(account);
        }
    }
}

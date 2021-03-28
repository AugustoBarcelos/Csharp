using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People();
            People p2 = new People();

            Console.WriteLine("First Employee");
            Console.WriteLine("Please, enter your name:");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Please, enter your Wage:");
            p1.Wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Second Employee");
            Console.WriteLine("Please, enter your name:");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Please, enter your Wage:");
            p2.Wage = double.Parse(Console.ReadLine());

            Console.WriteLine(p1.Wage + " " + p1.Name);
            Console.WriteLine(p2.Wage + " " + p2.Name);

            double average;

            average = (p1.Wage + p2.Wage) / 2;
            Console.WriteLine("Average Wage is: R$" + average);
        }
    }
}

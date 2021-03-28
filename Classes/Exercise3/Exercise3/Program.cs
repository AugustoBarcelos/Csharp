using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            student aluno = new student ();
            Console.WriteLine("Enter the student's Name:");
            aluno.Name = Console.ReadLine();
            Console.WriteLine("Enter the 1st grade:");
            aluno.grade1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd grade:");
            aluno.grade2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd grade:");
            aluno.grade3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Your Final Grade is: " +aluno.finalgrade().ToString("F2"));
            
            if (aluno.Aproved())
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Reproved");
                Console.WriteLine("It was missing: "+aluno.missing().ToString("F2"));
            }
        }
    }
}

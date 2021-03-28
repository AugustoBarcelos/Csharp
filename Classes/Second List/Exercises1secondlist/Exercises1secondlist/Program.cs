using System;

namespace Exercises1secondlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangle ret = new Retangle();
            Console.WriteLine("Enter the rectangle's width and height of the triangle:");
            ret.Width = double.Parse(Console.ReadLine());
            ret.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + ret.Area().ToString("F2")) ;
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2")) ;
            Console.WriteLine("Permiter = " + ret.Perimeter().ToString("F2")) ;

        }
    }
}

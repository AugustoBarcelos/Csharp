using System;

public class Program
{
	public static void Main()
	{
		string product1 = "Computer";
		string product2 = "Office Desk";
		
		byte age = 30;
		int code = 5290;
		char gender = 'M';
		
		double price1 = 2100.0;
		double price2 = 650.5;
		double average = 53.234567;
		
		Console.WriteLine("Products:");
		Console.WriteLine(product1+" which costs: $ "+price1.ToString("F2"));
		Console.WriteLine(product2+" which costs: $ "+price2.ToString("F2"));
		Console.WriteLine();
		Console.WriteLine("Register: "+age+ " years old,"+" code "+code+" and gender: "+gender);
		Console.WriteLine();
		Console.WriteLine("Measure with 8 decimal places: "+average.ToString("F8"));
		Console.WriteLine();
		Console.WriteLine("Rounding the numer (3 decimal places): "+average.ToString("F3"));
		Console.WriteLine();
		Console.WriteLine("Decimal separator invariant culture "+average.ToString("F3"));

	}
}

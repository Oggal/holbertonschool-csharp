using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
        Console.WriteLine(percent.ToString("P"));
        Console.WriteLine(currency.ToString("C", new System.Globalization.CultureInfo("en-US")));
	}
}
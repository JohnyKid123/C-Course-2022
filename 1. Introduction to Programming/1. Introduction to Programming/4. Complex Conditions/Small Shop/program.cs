using System;
					
public class Program
{
	public static void Main()
	{
		var product = Console.ReadLine();
		var city = Console.ReadLine();
		var unity = double.Parse(Console.ReadLine());
		if(city == "Sofia")
		{
			if(product == "coffee")
				Console.WriteLine(0.50 * unity);
			else if(product == "water")
				Console.WriteLine(0.80 * unity);
			else if(product == "beer")
				Console.WriteLine(1.20 * unity);
			else if(product == "sweets")
				Console.WriteLine(1.45 * unity);
			else if(product == "peanuts")
				Console.WriteLine(1.60 * unity);
		}
		else if(city == "Plovdiv")
		{
			if(product == "coffee")
				Console.WriteLine(0.40 * unity);
			else if(product == "water")
				Console.WriteLine(0.70 * unity);
			else if(product == "beer")
				Console.WriteLine(1.15 * unity);
			else if(product == "sweets")
				Console.WriteLine(1.30 * unity);
			else if(product == "peanuts")
				Console.WriteLine(1.50 * unity);
		}
		else if(city == "Varna")
		{
			if(product == "coffee")
				Console.WriteLine(0.45 * unity);
			else if(product == "water")
				Console.WriteLine(0.70 * unity);
			else if(product == "beer")
				Console.WriteLine(1.10 * unity);
			else if(product == "sweets")
				Console.WriteLine(1.35 * unity);
			else if(product == "peanuts")
				Console.WriteLine(1.55 * unity);
		}
	}
}

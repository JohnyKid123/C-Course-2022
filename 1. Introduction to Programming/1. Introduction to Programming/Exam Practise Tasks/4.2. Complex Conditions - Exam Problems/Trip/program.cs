using System;
public class Program
{
	public static void Main()
	{
		var budget = double.Parse(Console.ReadLine());
		var season = Console.ReadLine();
		if(season == "summer")
        {
			if(budget<=100)
            {
				var price = 0.3 * budget;
				Console.WriteLine("Somewhere in Bulgaria");
				Console.WriteLine("Camp - {0:F2}",price);
            }
			else if (budget <= 1000)
			{
				var price = 0.4 * budget;
				Console.WriteLine("Somewhere in Balkans");
				Console.WriteLine("Camp - {0:F2}", price);
			}
			else if (budget > 1000)
			{
				var price = 0.9 * budget;
				Console.WriteLine("Somewhere in Europe");
				Console.WriteLine("Hotel - {0:F2}", price);
			}
        }
		if (season == "winter")
		{
			if (budget <= 100)
			{
				var price = 0.7 * budget;
				Console.WriteLine("Somewhere in Bulgaria");
				Console.WriteLine("Hotel - {0:F2}", price);
			}
			else if (budget <= 1000)
			{
				var price = 0.8 * budget;
				Console.WriteLine("Somewhere in Balkans");
				Console.WriteLine("Hotel - {0:F2}", price);
			}
			else if (budget > 1000)
			{
				var price = 0.9 * budget;
				Console.WriteLine("Somewhere in Europe");
				Console.WriteLine("Hotel - {0:F2}", price);
			}
		}
	}
}

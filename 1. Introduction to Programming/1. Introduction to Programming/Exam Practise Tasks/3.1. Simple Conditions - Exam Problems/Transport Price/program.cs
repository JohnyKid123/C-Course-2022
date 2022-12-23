using System;
					
public class Program
{
	public static void Main()
	{
		var n = double.Parse(Console.ReadLine());
		string dayOrNight = Console.ReadLine();
		double price = 0;
		double taxiprice = 0;
		if(dayOrNight == "day")
		{
			taxiprice=0.79;
		}
		else 
		{
			taxiprice=0.90;
		}
		if(n<20)
		{
			price = 0.70 + n*taxiprice;
		}
		else if(n<100)
		{
			price = n*0.09;
		}
		else 
		{
			price = n*0.06;
		}
		Console.WriteLine(price);
	}
}

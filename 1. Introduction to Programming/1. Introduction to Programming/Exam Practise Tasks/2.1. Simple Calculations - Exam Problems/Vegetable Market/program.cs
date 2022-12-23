using System;
					
public class Program
{
	public static void Main()
	{
		var vegetables = double.Parse(Console.ReadLine());
		var fruits = double.Parse(Console.ReadLine());
		var kilos_veg = double.Parse(Console.ReadLine());
		var kilos_fru = double.Parse(Console.ReadLine());
		var price_veg = vegetables * kilos_veg;
		var price_fru = fruits * kilos_fru;
		Console.WriteLine((price_veg + price_fru)/1.94);
	}
						  
}

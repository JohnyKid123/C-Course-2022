using System;
					
public class Program
{
	public static void Main()
	{
		var v = double.Parse(Console.ReadLine());
		var p1 = double.Parse(Console.ReadLine());
		var p2 = double.Parse(Console.ReadLine());
		var h = double.Parse(Console.ReadLine());
		double water = (p1+p2)*h;
		if(water<=v)
		{
			  double waterPersent = water / v * 100;
              double p1Persent = p1 * h / water * 100;
              double p2Persent = p2 * h / water * 100;
			Console.WriteLine("The pool is " + "{0}" + "% full." +" " + "Pipe 1: " + "{1}" + "%. Pipe 2:" + " " + "{2}" + "%.",
				Math.Truncate( water / v * 100),
				Math.Truncate( p1 * h / water * 100),
				Math.Truncate( p2 * h / water * 100));
		}
		else 
		{
			double waterMore = water - v;
			Console.WriteLine("For " + h + " hours the pool overflows with " + waterMore + " liters.");
		}
	}
}

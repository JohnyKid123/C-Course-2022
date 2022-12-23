using System;
					
public class Program
{
	public static void Main()
	{
		var days = double.Parse(Console.ReadLine());
		var working_days = 365 - days;
		var minutes = working_days*63 + days*127;
		var dif = Math.Abs(minutes - 30000);
		var hour = dif/60;
		var min = dif%60;
		if(minutes>30000)
		{
			Console.WriteLine("Tom will run away");
			Console.WriteLine("{0}"+" hours and "+"{1}"+" minutes more for play",
				Math.Truncate( dif/60),
				Math.Truncate(dif%60));
		}
		else 
		{
			Console.WriteLine("Tom sleeps well");
			Console.WriteLine("{0}"+" hours and "+"{1}"+" minutes less for play",
				Math.Truncate( dif/60),
				Math.Truncate(dif%60));
		}
	}
}

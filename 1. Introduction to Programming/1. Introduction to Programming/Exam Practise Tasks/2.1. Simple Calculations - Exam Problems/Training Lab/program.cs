using System;
public class Program
{
	public static void Main()
	{
		var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var r = h * 100 / 120; 
            var s = (w * 100 - 100) / 70; 
            var f = Math.Truncate(r); 
            var t = Math.Truncate(s); 
            Console.WriteLine((t * f) - 3);
	}
}

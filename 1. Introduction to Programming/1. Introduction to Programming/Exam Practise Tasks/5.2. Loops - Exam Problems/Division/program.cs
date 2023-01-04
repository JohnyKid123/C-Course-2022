using System;
public class Program
{
	public static void Main()
	{
		var n = double.Parse(Console.ReadLine());
		var n1 = 0;
		var n2 = 0;
		var n3 = 0;
		for (int i=0; i<n; i++)
        {
			var num = int.Parse(Console.ReadLine());
			if (num % 2 == 0) n1++;
			if (num % 3 == 0) n2++;
			if (num % 4 == 0) n3++;
		}
		Console.WriteLine($"{n1 / n * 100:f2}%");
		Console.WriteLine($"{n2 / n * 100:f2}%");
		Console.WriteLine($"{n3 / n * 100:f2}%");

	}
}

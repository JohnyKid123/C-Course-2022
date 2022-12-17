using System;
					
public class Program
{
	public static void Main()
	{
		var inches = double.Parse(Console.ReadLine());
		var cant = inches * 2.54;
		Console.WriteLine("Cantimiters are :" + " " + cant);
	}
}

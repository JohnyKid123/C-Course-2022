using System;
					
public class Program
{
	public static void Main()
	{
		var r = double.Parse(Console.ReadLine());
		Console.WriteLine("Area is :" + " " + Math.PI * r * r);
		Console.WriteLine("Perimeter is :" + " " + 2*(Math.PI * r));
		
	}
						  
}

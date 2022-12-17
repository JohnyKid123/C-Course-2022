using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number in the range [1...100]:");
		int n = int.Parse(Console.ReadLine());
		while(n<1 || n>100)
		{
			Console.WriteLine("Ivalid Number!");
			n = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("The number is: {0}",n);
		
	}
}

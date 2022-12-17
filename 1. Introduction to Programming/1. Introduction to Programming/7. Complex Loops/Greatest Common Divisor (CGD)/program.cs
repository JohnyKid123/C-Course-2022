using System;
					
public class Program
{
	public static void Main()
	{
		var a  = int.Parse(Console.ReadLine());
		var b  = int.Parse(Console.ReadLine());
		while(b!=0)
		{
			var ob = b;
			b = a%b;
			a = ob;
		}
		Console.WriteLine(a);
	}
}

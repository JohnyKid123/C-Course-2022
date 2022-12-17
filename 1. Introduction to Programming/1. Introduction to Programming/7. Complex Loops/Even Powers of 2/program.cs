using System;
					
public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var num = 1;
		for(var i=0; i<=n; i+=2)
		{
		Console.WriteLine(num);
			num = num*2*2;
		}	
		
	}
}

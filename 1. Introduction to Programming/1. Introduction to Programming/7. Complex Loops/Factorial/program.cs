using System;
					
public class Program
{
	public static void Main()
	{
		var n  = int.Parse(Console.ReadLine());
		var num =1;
		do{
			num = n*(num);
			n--;
		}while(n>=1);
		Console.WriteLine(num);
			
	}
}

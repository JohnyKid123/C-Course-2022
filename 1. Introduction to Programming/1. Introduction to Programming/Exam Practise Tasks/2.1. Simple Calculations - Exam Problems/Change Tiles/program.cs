using System;
					
public class Program
{
	public static void Main()
	{
		var N = double.Parse(Console.ReadLine());
		var W = double.Parse(Console.ReadLine());
		var L = double.Parse(Console.ReadLine());
		var M = double.Parse(Console.ReadLine());
		var O = double.Parse(Console.ReadLine());
		var S = N*N;
		var SP = M*O;
		var PP = S - SP;
		var SPP = W*L;
		Console.WriteLine(PP/SPP);
		Console.WriteLine((PP/SPP)*0.2);
	}
						  
}

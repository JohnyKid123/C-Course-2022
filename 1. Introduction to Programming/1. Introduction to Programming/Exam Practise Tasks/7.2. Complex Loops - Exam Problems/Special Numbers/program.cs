using System;
public class Program
{
	public static void Main()
	{
		var num = int.Parse(Console.ReadLine());
			for (int n1 = 1; n1 < 9; n1++)
			{
				for (int n2 = 1; n2 <= 9; n2++)
				{
					for (int n3 = 1; n3 <= 9; n3++)
					{
						for (int n4 = 1; n4 <= 9; n4++)
						{
							if (num%n1==0 && num % n2 == 0 && num % n3 == 0 && num % n4 == 0)
							{
								Console.WriteLine($"{n1}{n2}{n3}{n4}");	
							}
						}
					}
				}
			}	

	}
}

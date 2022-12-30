using System;
public class Program
{
	public static void Main()
	{
		var a = int.Parse(Console.ReadLine());
		var b = int.Parse(Console.ReadLine());
		for (int n1 = 1; n1 <= a; n1++)
			{
				for (int n2 = 1; n2 <= a; n2++)
				{
					for (char n3 = 'a'; n3 <= 'a'+b; n3++)
					{
						for (char n4 = 'a'; n4 <= 'a'+b; n4++)
						{
							for(int n5 = Math.Max(n1,n2)+1; n5<=a; n5++)
							{
								Console.WriteLine($"{n1}{n2}{n3}{n4}{n5}");	
							}
						}
					}
				}
			}	
	}
}

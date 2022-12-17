using System;
					
public class Program
{
	public static void Main()
	{
		string password;
		password = Console.ReadLine();
		if(password =="s3cr3t!P@ssw0rd")
		{
			Console.WriteLine("Welcome");
		}
		else if(password != "s3cr3t!P@ssw0rd")
		{
			Console.WriteLine("Wrong password!");
		}
	}
}

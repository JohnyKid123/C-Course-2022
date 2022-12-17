using System;

public class Program
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
            double d = (r * 180) / Math.PI;
            Console.WriteLine(Math.Round(d));
    }
}

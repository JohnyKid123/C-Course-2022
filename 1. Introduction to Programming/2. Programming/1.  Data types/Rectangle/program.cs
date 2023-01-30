using System;

public class Program {
    public static void Main(string[] args) 
    {
        decimal length = decimal.Parse(Console.ReadLine());
decimal width = decimal.Parse(Console.ReadLine());
decimal circumference = 2 * (length + width);
decimal area = length * width;
decimal diagonal = (decimal)Math.Sqrt((double)(length * length + width * width));
Console.WriteLine(circumference);
Console.WriteLine(area);
Console.WriteLine(diagonal);
    }
}

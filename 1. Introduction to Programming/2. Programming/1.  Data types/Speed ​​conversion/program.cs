using System;

public class Program {
    public static void Main(string[] args) 
    {
        decimal distance = decimal.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());
decimal totalSeconds = hours * 3600 + minutes * 60 + seconds;
decimal metersPerSecond = distance / totalSeconds;
decimal kilometersPerHour = (distance / 1000) / (totalSeconds / 3600);
decimal milesPerHour = kilometersPerHour / 1.609m;
Console.WriteLine(metersPerSecond);
Console.WriteLine(kilometersPerHour);
Console.WriteLine(milesPerHour);
    }
}

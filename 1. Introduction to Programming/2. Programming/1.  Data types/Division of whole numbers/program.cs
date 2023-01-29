using System;

public class Program {
    public static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[2 * n];
        int totalLoss = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 2 * n; i += 2)
        {
            int quotient = numbers[i] / numbers[i + 1];
            int remainder = numbers[i] % numbers[i + 1];
            totalLoss += remainder;
            
        }

        Console.WriteLine(totalLoss);
    }
}

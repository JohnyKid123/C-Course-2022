using System;

namespace EvenNumberWithCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumberSafely();
            while (number % 2 != 0)
            {
                Console.WriteLine("Invalid number!");
                number = ReadNumberSafely();
            }

            Console.WriteLine($"Even number entered: {number}");
        }

        static int ReadNumberSafely()
        {
            Console.Write("Enter even number: ");      
            string input = Console.ReadLine();
            if (int.TryParse(input, out var number) == false) return -1;
            return number;
        }
    }
}

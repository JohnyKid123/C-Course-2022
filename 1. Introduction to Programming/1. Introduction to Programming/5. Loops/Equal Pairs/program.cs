using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;
            bool areTheSumsEqual = true;

            for (int p = 1; p <= n; p++)
            {
                int currentNumberOne = int.Parse(Console.ReadLine());
                int currentNumberTwo = int.Parse(Console.ReadLine());

                if (p % 2 == 0)
                {
                    evenSum = currentNumberOne + currentNumberTwo;
                }
                else
                {
                    oddSum = currentNumberTwo + currentNumberOne;
                }

                if (p > 1 && Math.Abs(evenSum - oddSum) > diff)
                {
                    diff = Math.Abs(evenSum - oddSum);
                    areTheSumsEqual = false;
                }
            }

            if (areTheSumsEqual == true)
            {
                Console.WriteLine($"Yes, value={oddSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}

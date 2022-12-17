using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score : ");
            var num = int.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            if (num <= 100) 
            {
                bonusPoints = 5;
            }
            else if ((num > 100) && (num <= 1000))
            {
                bonusPoints = num * 0.20;
            }
            else if (num > 1000) 
            {
                bonusPoints = num * 0.10;
            }
            if (num % 2 == 0) 
            {
                bonusPoints += 1;
            }
            else if (num % 10 == 5) 
            {
                bonusPoints += 2;
            }
            Console.WriteLine("Bonus score: {0}", bonusPoints);
            Console.WriteLine("Total score: {0}", num + bonusPoints);
        }
    }
}

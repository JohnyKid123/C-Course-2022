using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            var n = int.Parse(Console.ReadLine());
            var min = 1000000000000000;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("min = " + min);
        }
    }
}

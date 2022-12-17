using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var big = int.Parse(Console.ReadLine());
            var sum = big;
            for (var i = 2; i <= n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                sum = sum + a;
                if (a > big) big = a;
            }
            if (big == (sum - big))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum  = " + big);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(big - (sum - big)));
            }
        }
    }
}

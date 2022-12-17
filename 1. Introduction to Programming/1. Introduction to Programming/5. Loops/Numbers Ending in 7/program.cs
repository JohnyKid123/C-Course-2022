using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 1000; a++)
            {
                if (a % 10 == 7) Console.WriteLine(a);
            }
        }
    }
}

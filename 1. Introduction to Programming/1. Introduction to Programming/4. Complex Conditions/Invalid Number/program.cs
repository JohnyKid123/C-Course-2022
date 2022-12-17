using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var a = (num >= 100 && num <= 200) || num == 0;
            if (!a) Console.WriteLine("invalid");

        }
    }
}

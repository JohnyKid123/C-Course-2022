using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var currency = Console.ReadLine();
            var outcurrency = Console.ReadLine();

            decimal bgn = 0;
            if (currency == "BGN") bgn = money;
            else if (currency == "USD") bgn = money * 1.79549m;
            else if (currency == "EUR") bgn = money * 1.95583m;
            else if (currency == "GBP") bgn = money * 2.53405m;

            decimal result = 0;
            if (outcurrency == "BGN") result = bgn;
            else if (outcurrency == "USD") result = bgn / 1.79549m;
            else if (outcurrency == "EUR") result = bgn / 1.95583m;
            else if (outcurrency == "GBP") result = bgn / 2.53405m;

            Console.WriteLine($"{Math.Round(result, 2)} {outcurrency}");
        }
    }
}

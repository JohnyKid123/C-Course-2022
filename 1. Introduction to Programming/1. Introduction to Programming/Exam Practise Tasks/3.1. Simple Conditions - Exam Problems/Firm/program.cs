using System;
namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var needTime = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            double firmdays = days*0.9;
            var workHfirm = firmdays * 8 * workers;
            double overtime = workers * firmdays * 2;
            double totalFirmTime =Math.Floor(workHfirm + overtime);
            var diff =Math.Abs(totalFirmTime - needTime);
            if (needTime <= totalFirmTime)
            {
                Console.WriteLine("Yes!{0} hours left.", (diff));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Ceiling(diff));
 
            }
        }
    }
}

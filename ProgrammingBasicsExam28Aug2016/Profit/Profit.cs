using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var daysWorking = int.Parse(Console.ReadLine());
            var dailyProfit = double.Parse(Console.ReadLine());
            var dollarToLev = double.Parse(Console.ReadLine());

            var wage = daysWorking * dailyProfit;
            var annualProfit = wage * 12 + wage * 2.5;
            var afterTaxes = 0.75 * annualProfit;
            var profitInLeva = afterTaxes * dollarToLev;
            var averagePerDay = profitInLeva / 365.0;
            Console.WriteLine("{0:f2}", averagePerDay);
        }
    }
}

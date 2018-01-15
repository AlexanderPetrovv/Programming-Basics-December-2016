using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            var daysWorking = int.Parse(Console.ReadLine());
            var moneyPerDay = decimal.Parse(Console.ReadLine());
            var usdBgnRate = decimal.Parse(Console.ReadLine());
            var wageMonth = daysWorking * moneyPerDay;
            var wageAnnual = (12 * wageMonth) + (2.5m * wageMonth);
            var tax = 25 * wageAnnual / 100;
            var wageAfterTaxes = wageAnnual - tax;
            var wageLevs = wageAfterTaxes * usdBgnRate;
            var averageDailyProfit = wageLevs / 365;

            Console.WriteLine(Math.Round(averageDailyProfit, 2));
        }
    }
}

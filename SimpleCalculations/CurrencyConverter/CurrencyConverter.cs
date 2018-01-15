using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            decimal bgn = 1m;
            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;

            switch (inputCurrency)
            {
                case "BGN": break;
                case "USD": amount = amount * usd; break;
                case "EUR": amount = amount * eur; break;
                case "GBP": amount = amount * gbp; break;
                default: break;
            }

            switch (outputCurrency)
            {
                case "BGN": amount = amount / bgn; break;
                case "USD": amount = amount / usd; break;
                case "EUR": amount = amount / eur; break;
                case "GBP": amount = amount / gbp; break;
                default: break;
            }
            Console.WriteLine(Math.Round(amount, 2) + " " + outputCurrency);
        }
    }
}

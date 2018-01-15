using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterWithIfs
{
    class CurrencyConverterWithIfs
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            var convertFrom = Console.ReadLine();
            var convertTo = Console.ReadLine();

            decimal bgn = 1m;
            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;

            if (convertFrom == "BGN" && convertTo == "USD") 
            {
                Console.WriteLine(Math.Round((amount / usd), 2) + " " + convertTo);
            }
            if (convertFrom == "BGN" && convertTo == "EUR")
            {
                Console.WriteLine(Math.Round((amount / eur), 2) + " " + convertTo);
            }
            if (convertFrom == "BGN" && convertTo == "GBP")
            {
                Console.WriteLine(Math.Round((amount / gbp), 2) + " " + convertTo);
            }
            if (convertFrom == "USD" && convertTo == "BGN")
            {
                Console.WriteLine(Math.Round(((amount * usd) / bgn), 2) + " " + convertTo);
            }
            if (convertFrom == "USD" && convertTo == "EUR")
            {
                Console.WriteLine(Math.Round((amount * usd) / eur, 2) + " " + convertTo );
            }
            if (convertFrom == "USD" && convertTo == "GBP")
            {
                Console.WriteLine(Math.Round((amount * usd) / gbp, 2) + " " + convertTo);
            }
            if (convertFrom == "EUR" && convertTo == "BGN")
            {
                Console.WriteLine(Math.Round(((amount * eur) / bgn), 2) + " " + convertTo);
            }
            if (convertFrom == "EUR" && convertTo == "USD")
            {
                Console.WriteLine(Math.Round(((amount * eur) / usd), 2) + " " + convertTo);
            }
            if (convertFrom == "EUR" && convertTo == "GBP")
            {
                Console.WriteLine(Math.Round(((amount * eur) / gbp), 2) + " " + convertTo);
            }
            if (convertFrom == "GBP" && convertTo == "BGN")
            {
                Console.WriteLine(Math.Round(((amount * gbp) / bgn), 2) + " " + convertTo);
            }
            if (convertFrom == "GBP" && convertTo == "USD")
            {
                Console.WriteLine(Math.Round(((amount * gbp) / usd), 2) + " " + convertTo);
            }
            if (convertFrom == "GBP" && convertTo == "EUR")
            {
                Console.WriteLine(Math.Round(((amount * gbp) / eur), 2) + " " + convertTo);
            }
        }
    }
}

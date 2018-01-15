using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterWithElseIf
{
    class CurrencyConverterWithElseIf
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();
            decimal firstRate = 0.0m;
            decimal secondRate = 0.0m;

            if (convertFrom == "BGN")
            {
                firstRate = 1m;
            }
            else if (convertFrom == "USD")
            {
                firstRate = 1.79549m;
            }
            else if (convertFrom == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if (convertFrom == "GBP")
            {
                firstRate = 2.53405m;
            }

            if (convertTo == "BGN")
            {
                secondRate = 1m;
            }
            else if (convertTo == "USD")
            {
                secondRate = 1.79549m;
            }
            else if (convertTo == "EUR")
            {
                secondRate = 1.95583m;
            }
            else if (convertTo == "GBP")
            {
                secondRate = 2.53405m;
            }

            decimal result = amount * firstRate / secondRate;
            Console.WriteLine(Math.Round(result, 2) + " " + convertTo);
        }
    }
}

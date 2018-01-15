using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoinCount = int.Parse(Console.ReadLine());
            var yuansCount = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var bitcoinToLev = 1168;
            var yuanToDollar = 0.15;
            var dollarToLev = 1.76;
            var euroToLev = 1.95;

            var totalEuro = (bitcoinCount * 1168 + yuansCount * 0.15 * 1.76) / 1.95;
            var result = totalEuro - (totalEuro * comission / 100.0);
            Console.WriteLine(result);
        }
    }
}

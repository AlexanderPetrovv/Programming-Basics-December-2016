using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            var mackerelPrice = double.Parse(Console.ReadLine());          // skumriq
            var spratPrice = double.Parse(Console.ReadLine());            // caca
            var bonitoKg = double.Parse(Console.ReadLine());             // palamud
            var trachurusKg = double.Parse(Console.ReadLine());         // safrid
            var musselsKg = double.Parse(Console.ReadLine());          // midi

            var bonitoPrice = mackerelPrice * 1.6;
            var trachurusPrice = spratPrice * 1.8;
            var musselsPrice = 7.5;

            var total = bonitoKg * bonitoPrice + trachurusKg * trachurusPrice + musselsKg * musselsPrice;
            Console.WriteLine("{0:f2}", total);
        }
    }
}

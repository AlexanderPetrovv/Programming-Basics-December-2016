using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowCnt = int.Parse(Console.ReadLine());
            var styrofoamPerPack = double.Parse(Console.ReadLine());
            var styrofoamPackPrice = double.Parse(Console.ReadLine());

            var windowArea = 2.4;
            var workArea = (houseArea - windowArea * windowCnt) * 1.1;
            var packs = Math.Ceiling(workArea / styrofoamPerPack);
            var price = packs * styrofoamPackPrice;

            if (price <= budget)
            {
                Console.WriteLine("Spent: {0:f2}", price);
                Console.WriteLine("Left: {0:f2}", budget - price);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", price - budget);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vineyardArea = int.Parse(Console.ReadLine());
            var grapeSquareMeter = double.Parse(Console.ReadLine());
            var wineLitresNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalGrape = vineyardArea * grapeSquareMeter;
            var grapeForWine = 0.4 * totalGrape;
            var wineLitres = grapeForWine / 2.5;

            var diff = wineLitres - wineLitresNeeded;

            if (diff >= 0)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineLitres));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(diff), Math.Ceiling(diff / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(-diff));
            }
        }
    }
}

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
            var area = int.Parse(Console.ReadLine());
            var grapePerKm = double.Parse(Console.ReadLine());
            var litersNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapeTotal = grapePerKm * area;
            var wine = 0.4 * grapeTotal / 2.5;

            if (wine < litersNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litersNeeded - wine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - litersNeeded), Math.Ceiling((wine - litersNeeded) / workers));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var leftFoodKg = int.Parse(Console.ReadLine());
            var dogFoodPerDay = double.Parse(Console.ReadLine());
            var catFoodPerDay = double.Parse(Console.ReadLine());
            var tortoiseFoodPerDay = double.Parse(Console.ReadLine()) / 1000;

            var foodNeeded = days * (dogFoodPerDay + catFoodPerDay + tortoiseFoodPerDay);

            if (foodNeeded <= leftFoodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(leftFoodKg - foodNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeeded - leftFoodKg));
            }
        }
    }
}

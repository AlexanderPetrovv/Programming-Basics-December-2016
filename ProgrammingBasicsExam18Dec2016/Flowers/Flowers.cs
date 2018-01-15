using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var chrysanthemums = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var isHoliday = Console.ReadLine();

            var chrysPrice = 0.0;
            var rosePrice = 0.0;
            var tulipPrice = 0.0;

            switch (season.ToLower())
            {
                case "spring":
                case "summer":
                    chrysPrice = 2.0;
                    rosePrice = 4.1;
                    tulipPrice = 2.5;
                    break;
                case "autumn":
                case "winter":
                    chrysPrice = 3.75;
                    rosePrice = 4.5;
                    tulipPrice = 4.15;
                    break;
            }

            var price = chrysanthemums * chrysPrice + roses * rosePrice + tulips * tulipPrice;
            if (isHoliday.ToLower() == "y")
            {
                price *= 1.15;
            }

            if (season.ToLower() == "spring" && tulips > 7)
            {
                price *= 0.95;
            }

            if (season.ToLower() == "winter" && roses >= 10)
            {
                price *= 0.9;
            }

            if (chrysanthemums + roses + tulips > 20)
            {
                price *= 0.8;
            }

            price += 2;
            Console.WriteLine("{0:f2}", price);
        }
    }
}

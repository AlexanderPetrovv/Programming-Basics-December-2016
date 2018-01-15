using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var carClass = "";
            var carType = "";
            var price = 0.0;

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = 0.8 * budget;
                }
            }
            else
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = 0.9 * budget;
            }

            Console.WriteLine("{0}", carClass);
            Console.WriteLine("{0} - {1:f2}", carType, price);
        }
    }
}

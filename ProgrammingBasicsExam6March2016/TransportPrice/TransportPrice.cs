using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine();
            var price = 0.0;

            if (km < 20)
            {
                if (dayNight.ToLower() == "day")
                {
                    price = 0.79 * km + 0.7;
                }
                else if (dayNight.ToLower() == "night")
                {
                    price = 0.9 * km + 0.7;
                }
            }
            else if (km < 100)
            {
                price = 0.09 * km;
            }
            else
            {
                price = 0.06 * km;
            }

            Console.WriteLine(price);
        }
    }
}

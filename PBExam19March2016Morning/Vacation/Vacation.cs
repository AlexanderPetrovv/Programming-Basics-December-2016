using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var place = "";
            var location = "";
            var costs = 0.0;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    costs = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    costs = 0.45 * budget;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    costs = 0.8 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    costs = 0.6 * budget;
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    costs = 0.9 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    costs = 0.9 * budget;
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", location, place, costs);
        }
    }
}

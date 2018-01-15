using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var distance = double.Parse(Console.ReadLine());

            var moneyPerKm = 0.0;

            switch (season.ToLower())
            {
                case "spring":
                case "autumn":
                    if (distance <= 5000) moneyPerKm = 0.75;
                    else if (distance <= 10000) moneyPerKm = 0.95;
                    else if (distance <= 20000) moneyPerKm = 1.45;
                    break;
                case "summer":
                    if (distance <= 5000) moneyPerKm = 0.9;
                    else if (distance <= 10000) moneyPerKm = 1.1;
                    else if (distance <= 20000) moneyPerKm = 1.45;
                    break;
                case "winter":
                    if (distance <= 5000) moneyPerKm = 1.05;
                    else if (distance <= 10000) moneyPerKm = 1.25;
                    else if (distance <= 20000) moneyPerKm = 1.45;
                    break;
            }

            var income = moneyPerKm * distance * 4 * 0.9;
            Console.WriteLine("{0:f2}", income);
        }
    }
}

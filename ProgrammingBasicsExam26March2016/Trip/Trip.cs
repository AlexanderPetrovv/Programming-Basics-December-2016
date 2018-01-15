using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var station = "";
            var destination = "";
            var expenses = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season.ToLower() == "summer")
                {
                    station = "Camp";
                    expenses = 0.3 * budget;
                }
                else if (season.ToLower() == "winter")
                {
                    station = "Hotel";
                    expenses = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season.ToLower() == "summer")
                {
                    station = "Camp";
                    expenses = 0.4 * budget;
                }
                else if (season.ToLower() == "winter")
                {
                    station = "Hotel";
                    expenses = 0.8 * budget;
                }
            }
            else
            {
                destination = "Europe";
                station = "Hotel";
                expenses = 0.9 * budget;
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", station, expenses);
        }
    }
}

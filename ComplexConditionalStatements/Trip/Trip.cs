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
            var season = Console.ReadLine().ToLower();

            var destination = "";
            var expenses = 0.0;
            var restIn = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = budget * 0.3;
                    restIn = "Camp";
                }
                else  // season == winter
                {
                    expenses = budget * 0.7;
                    restIn = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    expenses = budget * 0.4;
                    restIn = "Camp";
                }
                else // season == winter
                {
                    expenses = budget * 0.8;
                    restIn = "Hotel";
                }
            }
            else  // budget > 1000
            {
                destination = "Europe";
                expenses = budget * 0.9;
                restIn = "Hotel";  // same for summer and winter
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", restIn, expenses);
        }
    }
}

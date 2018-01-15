using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var ticketType = Console.ReadLine().ToLower();
            var group = double.Parse(Console.ReadLine());

            var transport = 0.0;
            var expenses = 0.0;
            var ticketPrice = 0.0;

            if (group >= 1 && group <= 4)
            {
                transport = budget * 0.75;
            }
            else if (group >= 5 && group <= 9)
            {
                transport = budget * 0.6;
            }
            else if (group >= 10 && group <= 24)
            {
                transport = budget * 0.5;
            }
            else if (group >= 25 && group <= 49)
            {
                transport = budget * 0.4;
            }
            else if (group >= 50)
            {
                transport = budget * 0.25;
            }

            if (ticketType == "vip")
            {
                ticketPrice = 499.99 * group;
                expenses = (budget - transport) - ticketPrice;
                Console.WriteLine(expenses >= 0 ? "Yes! You have {0:f2} leva left." : "Not enough money! You need {1:f2} leva.", expenses, -expenses);
            }
            else if (ticketType == "normal")
            {
                ticketPrice = 249.99 * group;
                expenses = (budget - transport) - ticketPrice;
                Console.WriteLine(expenses >= 0 ? "Yes! You have {0:f2} leva left." : "Not enough money! You need {1:f2} leva.", expenses, -expenses);
            }
        }
    }
}

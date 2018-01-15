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
            var ticketCategory = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var transportMoney = 0.0;

            if (people > 0 && people <= 4)
            {
                transportMoney = 0.75 * budget;
            }
            else if (people <= 9)
            {
                transportMoney = 0.6 * budget;
            }
            else if (people <= 24)
            {
                transportMoney = 0.5 * budget;
            }
            else if (people <= 49)
            {
                transportMoney = 0.4 * budget;
            }
            else if (people > 50)
            {
                transportMoney = 0.25 * budget;
            }

            var ticketPrice = 249.99;
            if (ticketCategory.ToLower() == "vip")
            {
                ticketPrice = 499.99;
            }
            var diff = budget - transportMoney - (ticketPrice * people);

            if (diff < 0)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", -diff);
            }
            else
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
            }
        }
    }
}

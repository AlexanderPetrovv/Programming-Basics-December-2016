using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTicketsVariation
{
    class MatchTicketsVariation
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var ticketPrice = category == "VIP" ? 499.99 : 249.99;

            var moneyLeft = budget;
            if (people < 5)
            {
                moneyLeft -= budget * 0.75;
            }
            else if (people >= 5 && people < 10)
            {
                moneyLeft -= budget * 0.6;
            }
            else if (people >= 10 && people < 25)
            {
                moneyLeft -= budget * 0.5;
            }
            else if (people >= 25 && people < 50)
            {
                moneyLeft -= budget * 0.4;
            }
            else
            {
                moneyLeft -= budget * 0.25;
            }

            var allTicketsPrice = people * ticketPrice;
            if (allTicketsPrice > moneyLeft)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", allTicketsPrice - moneyLeft);
            }
            else
            {
                moneyLeft -= allTicketsPrice;
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
            }
        }
    }
}

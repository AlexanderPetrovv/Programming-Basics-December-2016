using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsTravelling = int.Parse(Console.ReadLine());

            double weekendsSofia = 48 - weekendsTravelling;
            double saturdayGames = weekendsSofia * 3.0 / 4;
            double holidayGamesSf = holidays * 2.0 / 3;
            double totalGames = 0.0;

            if (yearType == "leap")
            {
                totalGames = (saturdayGames + holidayGamesSf + weekendsTravelling) * 1.15;
            }
            else  // yearType == normal
            {
                totalGames = saturdayGames + holidayGamesSf + weekendsTravelling;
            }
            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}

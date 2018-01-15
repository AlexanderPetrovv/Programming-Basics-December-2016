using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var juniorsCount = int.Parse(Console.ReadLine());
            var seniorsCount = int.Parse(Console.ReadLine());
            var raceType = Console.ReadLine();

            var juniorTax = 0.0;
            var seniorTax = 0.0;

            if (raceType.ToLower() == "trail")
            {
                juniorTax = 5.5;
                seniorTax = 7.0;
            }
            else if (raceType.ToLower() == "cross-country")
            {
                juniorTax = 8.0;
                seniorTax = 9.5;
                if (juniorsCount + seniorsCount >= 50)
                {
                    juniorTax = 8.0 * 0.75;
                    seniorTax = 9.5 * 0.75; 
                }
            }
            else if (raceType.ToLower() == "downhill")
            {
                juniorTax = 12.25;
                seniorTax = 13.75;
            }
            else if (raceType.ToLower() == "road")
            {
                juniorTax = 20;
                seniorTax = 21.50;
            }

            var donation = (juniorTax * juniorsCount + seniorTax * seniorsCount) * 0.95;
            Console.WriteLine("{0:f2}", donation);
        }
    }
}

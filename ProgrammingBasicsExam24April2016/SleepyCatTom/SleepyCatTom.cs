using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main(string[] args)
        {
            var freeDays = int.Parse(Console.ReadLine());
            var daysPerYear = 365;
            var workingDays = daysPerYear - freeDays;
            var tomSleepNeeds = 30000;

            var playingWhenWorking = 63 * workingDays;
            var playingWhenFree = 127 * freeDays;
            var diff = tomSleepNeeds - playingWhenWorking - playingWhenFree;

            if (diff < 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", -diff / 60, -diff % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
            }
        }
    }
}

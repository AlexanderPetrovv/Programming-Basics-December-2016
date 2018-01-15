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
            var daysOff = int.Parse(Console.ReadLine());
            var daysAtWork = 365 - daysOff;
            var playTime = (daysAtWork * 63) + (daysOff * 127);

            if (playTime <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000 - playTime) / 60, (30000 - playTime) % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs((30000 - playTime) / 60), Math.Abs((30000 - playTime) % 60));
            }
        }
    }
}

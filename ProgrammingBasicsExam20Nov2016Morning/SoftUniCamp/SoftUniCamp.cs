using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            var carGroup = 0;
            var microbusGroup = 0;
            var smallBusGroup = 0;
            var bigBusGroup = 0;
            var trainGroup = 0;
            var totalPeople = 0;

            for (int i = 0; i < groups; i++)
            {
                var peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;
                if (peopleInGroup <= 5) carGroup += peopleInGroup;
                else if (peopleInGroup <= 12) microbusGroup += peopleInGroup;
                else if (peopleInGroup <= 25) smallBusGroup += peopleInGroup;
                else if (peopleInGroup <= 40) bigBusGroup += peopleInGroup;
                else if (peopleInGroup > 40) trainGroup += peopleInGroup;
            }

            Console.WriteLine("{0:f2}%", carGroup * 100.0 / totalPeople);
            Console.WriteLine("{0:f2}%", microbusGroup * 100.0 / totalPeople);
            Console.WriteLine("{0:f2}%", smallBusGroup * 100.0 / totalPeople);
            Console.WriteLine("{0:f2}%", bigBusGroup * 100.0 / totalPeople);
            Console.WriteLine("{0:f2}%", trainGroup * 100.0 / totalPeople);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int cups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int daysWorking = int.Parse(Console.ReadLine());

            var totalWorkHours = workers * daysWorking * 8;
            var cupsMade = Math.Floor(totalWorkHours / 5.0);

            if (cupsMade < cups)
            {
                Console.WriteLine("Losses: {0:f2}", (cups - cupsMade) * 4.2);
            }
            else
            {
                Console.WriteLine("{0:f2} extra money", (cupsMade - cups) * 4.2);
            }
        }
    }
}

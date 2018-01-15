using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var daysAvailable = int.Parse(Console.ReadLine());
            var workersExtraTime = int.Parse(Console.ReadLine());

            var trainingTime = 0.1 * daysAvailable;
            var extraTime = workersExtraTime * 2 * daysAvailable;
            var projectTime = Math.Floor((daysAvailable - trainingTime) * 8 + extraTime);

            if (projectTime >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", projectTime - hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - projectTime);
            }
        }
    }
}

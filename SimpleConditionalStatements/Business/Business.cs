using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Business
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var training = 0.1 * days;
            var workingTime = (days - training) * 8;
            var extraWorking = workers * 2 * days;
            var totalHours = Math.Floor(workingTime + extraWorking);

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(totalHours - hoursNeeded));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var workingHours = workers * workingDays * 8;
            
            if (hoursNeeded > workingHours)
            {
                var penalties = (hoursNeeded - workingHours) * workingDays;
                Console.WriteLine("{0} overtime", hoursNeeded - workingHours);
                Console.WriteLine("Penalties: " + penalties);
            }
            else
            {
                Console.WriteLine("{0} hours left", workingHours - hoursNeeded);
            }
        }
    }
}

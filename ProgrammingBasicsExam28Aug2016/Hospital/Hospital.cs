using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var pertiod = int.Parse(Console.ReadLine());
            var doctors = 7;
            var totalUntreated = 0;
            var totalTreated = 0;
            for (int day = 1; day <= pertiod; day++)
            {
                var patients = int.Parse(Console.ReadLine());

                if (day % 3 == 0)
                {
                    if (totalUntreated > totalTreated)
                    {
                        doctors++;
                    }
                }

                if (patients > doctors)
                {
                    totalTreated += doctors;
                    totalUntreated += patients - doctors;
                }
                else
                {
                    totalTreated += patients;
                }
            }

            Console.WriteLine("Treated patients: {0}.", totalTreated);
            Console.WriteLine("Untreated patients: {0}.", totalUntreated);
        }
    }
}

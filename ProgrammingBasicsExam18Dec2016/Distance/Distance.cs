using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var initialSpeed = int.Parse(Console.ReadLine());
            var firstTimeMin = int.Parse(Console.ReadLine()) / 60.0;
            var secondTimeMin = int.Parse(Console.ReadLine()) / 60.0;
            var thirdTimeMin = int.Parse(Console.ReadLine()) / 60.0;

            var firstDistance = initialSpeed * firstTimeMin;
            var secondDistance = initialSpeed * 1.1 * secondTimeMin;
            var thirdDistance = initialSpeed * 1.1 * 0.95 * thirdTimeMin;
            var totalDistance = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine("{0:f2}", totalDistance);
        }
    }
}

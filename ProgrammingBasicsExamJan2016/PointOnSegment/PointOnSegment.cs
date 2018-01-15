using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var pointX = int.Parse(Console.ReadLine());

            if (Math.Min(first,second) <= pointX && pointX <= Math.Max(first, second))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            var distanceToFirst = Math.Abs(first - pointX);
            var distanceToSecond = Math.Abs(second - pointX);
            var closestDistance = Math.Min(distanceToFirst, distanceToSecond);
            Console.WriteLine(closestDistance);
        }
    }
}

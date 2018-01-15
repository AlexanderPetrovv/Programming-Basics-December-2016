using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleAndRect
{
    class PointCircleAndRect
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var inCircle = x * x + y * y <= 5 * 5;
            var outRect = (x < -1 || x > 5) || (y < 1 || y > 5);
            Console.WriteLine(inCircle && outRect ? "Point is inside circle and outside the rectangle at the same time." : "Point is NOT inside the circle and outside the rectangle at the same time.");
        }
    }
}

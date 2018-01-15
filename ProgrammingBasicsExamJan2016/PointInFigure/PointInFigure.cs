using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            // Horizontal rectangle coordinates
            var x1 = 2;
            var y1 = -3;
            var x2 = 12;
            var y2 = 1;
            // Vertical rectangle coordinates
            var x3 = 4;
            var y3 = -5;
            var x4 = 10;
            var y4 = 3;

            var isPointInHorizontalRect = (x >= x1 && x <= x2) && (y >= y1 && y <= y2);
            var isPointInVerticalRect = (x >= x3 && x <= x4) && (y >= y3 && y <= y4);

            if (isPointInHorizontalRect || isPointInVerticalRect)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}

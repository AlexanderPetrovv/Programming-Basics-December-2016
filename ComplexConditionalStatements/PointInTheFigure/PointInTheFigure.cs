using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var x1 = 0;
            var y1 = 0;
            var x2 = 3 * h;
            var y2 = h;
            var x3 = h;
            var y3 = h;
            var x4 = 2 * h;
            var y4 = 4 * h;

            var borderRectOne = (x == x1 || x == x2) && (y >= y1 && y <= y2) || 
                                (y == y1 || y == y2) && (x >= x1 && x <= x2);
            var borderRectTwo = (x == x3 || x == x4) && (y >= y3 && y <= y4) || 
                                (y == y3 || y == y4) && (x >= x3 && x <= x4);

            var insideRectOne = (x > x1 && x < x2) && (y > y1 && y < y2);
            var insideRectTwo = (x > x3 && x < x4) && (y > y3 && y < y4);
            var commonSide = x > h && x < (2 * h) && y == h;

            if (insideRectOne || insideRectTwo || commonSide)
            {
                Console.WriteLine("inside");
            }
            else if (borderRectOne || borderRectTwo)
            {
                Console.WriteLine("border");
            }
            else  // point is outside
            {
                Console.WriteLine("outside");
            }
        }
    }
}

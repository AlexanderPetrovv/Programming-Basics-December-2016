using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine(x * x + y * y <= 5 * 5 ? "Point is inside the circle" : "Point is outside the circle"); 
        }
    }
}

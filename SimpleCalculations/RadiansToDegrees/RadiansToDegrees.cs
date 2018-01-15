using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = (180 * rad) / Math.PI;
            Console.WriteLine("Degrees = {0}", Math.Round(deg, MidpointRounding.AwayFromZero));
        }
    }
}

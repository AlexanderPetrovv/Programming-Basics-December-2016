using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());

            var p1Count = 0.0;
            var p2Count = 0.0;
            var p3Count = 0.0;
            var p4Count = 0.0;
            var p5Count = 0.0;

            for (int i = 0; i < numbers; i++)
            {
                var input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 1000)
                {
                    Console.WriteLine("Numbers are out of range!");
                }
                else if (input < 200)
                {
                    p1Count++;
                }
                else if (input <= 399)
                {
                    p2Count++;
                }
                else if (input <= 599)
                {
                    p3Count++;
                }
                else if (input <= 799)
                {
                    p4Count++;
                }
                else if (input >= 800)
                {
                    p5Count++;
                }
            }

            var p1 = p1Count / numbers * 100;
            Console.WriteLine("{0:f2}%", p1);

            var p2 = p2Count / numbers * 100;
            Console.WriteLine("{0:f2}%", p2);

            var p3 = p3Count / numbers * 100;
            Console.WriteLine("{0:f2}%", p3);

            var p4 = p4Count / numbers * 100;
            Console.WriteLine("{0:f2}%", p4);

            var p5 = p5Count / numbers * 100;
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}

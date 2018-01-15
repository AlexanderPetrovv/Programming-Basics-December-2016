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
            var numberCount = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int num = 0; num < numberCount; num++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number <= 399)
                {
                    p2 += 1;
                }
                else if (number <= 599)
                {
                    p3 += 1;
                }
                else if (number <= 799)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }

            p1 = p1 / numberCount * 100;
            Console.WriteLine("{0:f2} %", p1);
            p2 = p2 / numberCount * 100;
            Console.WriteLine("{0:f2} %", p2);
            p3 = p3 / numberCount * 100;
            Console.WriteLine("{0:f2} %", p3);
            p4 = p4 / numberCount * 100;
            Console.WriteLine("{0:f2} %", p4);
            p5 = p5 / numberCount * 100;
            Console.WriteLine("{0:f2} %", p5);
        }
    }
}

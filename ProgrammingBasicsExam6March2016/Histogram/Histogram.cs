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
            var n = int.Parse(Console.ReadLine());

            var count1 = 0.0;
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;
            var count5 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1++;
                }
                else if (number < 400)
                {
                    count2++;
                }
                else if (number < 600)
                {
                    count3++;
                }
                else if (number < 800)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }
            }

            var p1 = count1 / n * 100;
            Console.WriteLine("{0:f2}%", p1);
            var p2 = count2 / n * 100;
            Console.WriteLine("{0:f2}%", p2);
            var p3 = count3 / n * 100;
            Console.WriteLine("{0:f2}%", p3);
            var p4 = count4 / n * 100;
            Console.WriteLine("{0:f2}%", p4);
            var p5 = count5 / n * 100;
            Console.WriteLine("{0:f2}%", p5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count1 = 0;
            var count2 = 0;
            var count3 = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }

                if (number % 3 == 0)
                {
                    count2++;
                }

                if (number % 4 == 0)
                {
                    count3++;
                }
            }

            var p1 = count1 * 100.0 / n;
            var p2 = count2 * 100.0 / n;
            var p3 = count3 * 100.0 / n;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}

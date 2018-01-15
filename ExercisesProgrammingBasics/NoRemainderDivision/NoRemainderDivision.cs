using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoRemainderDivision
{
    class NoRemainderDivision
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            for (int num = 0; num < numberCount; num++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }

                if (number % 3 == 0)
                {
                    p2++;
                }

                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            p1 = p1 / numberCount * 100;
            Console.WriteLine("{0:f2}%", p1);
            p2 = p2 / numberCount * 100;
            Console.WriteLine("{0:f2}%", p2);
            p3 = p3 / numberCount * 100;
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}

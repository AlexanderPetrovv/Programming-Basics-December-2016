using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < numberCount; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }

                if (num % 3 == 0)
                {
                    p2++;
                }

                if (num % 4 == 0)
                {
                    p3++;
                }
            }

            var divideByTwo = p1 * 100 / numberCount;
            var divideByThree = p2 * 100 / numberCount;
            var divideByFour = p3 * 100 / numberCount;

            Console.WriteLine("{0:f2}%", divideByTwo);
            Console.WriteLine("{0:f2}%", divideByThree);
            Console.WriteLine("{0:f2}%", divideByFour);
        }
    }
}

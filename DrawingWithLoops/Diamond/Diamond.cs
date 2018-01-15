using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dashUp = (n - 1) / 2;
            //upper part
            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.Write(new string('-', dashUp));
                Console.Write("*");
                var midDash = n - 2 - (2 * dashUp);
                if (midDash >= 0)
                {
                    Console.Write(new string('-', midDash));
                    Console.Write("*");
                }
                Console.Write(new string('-', dashUp));
                dashUp--;
                Console.WriteLine();
            }
            //lower part
            var dashLow = 1;
            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write(new string('-', dashLow));
                Console.Write("*");
                var midDash = n - 2 - (2 * dashLow);
                if (midDash >= 0)
                {
                    Console.Write(new string('-', midDash));
                    Console.Write("*");
                }
                Console.Write(new string('-', dashLow));
                dashLow++;
                Console.WriteLine();
            }
        }
    }
}

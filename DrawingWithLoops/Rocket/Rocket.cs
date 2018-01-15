using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 3 * n;
            // top part
            var dots = (width - 2) / 2;
            var spaces = 0;
            for (int topRow = 0; topRow < n; topRow++)
            {
                spaces = width - dots * 2 - 2;
                Console.Write("{0}/{1}\\{0}", new string('.', dots), new string(' ', spaces));
                dots--;
                Console.WriteLine();
            }

            // mid part
            var midHeight = 2 * n + 1;
            for (int midRow = 1; midRow < midHeight; midRow++)
            {
                if (midRow == 1)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('*', width - n));
                    Console.WriteLine(new string('.', n / 2));
                }

                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', width - n - 2));
            }

            // bottom part
            var botDots = n / 2;
            for (int botRow = 0; botRow < n / 2; botRow++)
            {
                var botStars = width - botDots * 2 - 2;
                Console.WriteLine("{0}/{1}\\{0}", new string('.', botDots), new string('*', botStars));
                botDots--;
            }
        }
    }
}

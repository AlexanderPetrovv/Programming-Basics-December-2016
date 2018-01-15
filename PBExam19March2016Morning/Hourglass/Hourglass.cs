using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var columns = 2 * n + 1;

            // top row
            Console.WriteLine(new string('*', columns));

            // top half
            for (int topRow = 1; topRow <= n - 1; topRow++)
            {
                var sandSymbol = '@';
                if (topRow == 1)
                {
                    sandSymbol = ' ';
                }
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', topRow),
                    new string(sandSymbol, 2 * n - 1 - 2 * topRow));
            }

            // mid row
            Console.WriteLine("{0}*{0}", new string('.', n));

            // bot half
            for (int botRow = n - 1; botRow >= 1; botRow--)
            {
                var glassSpace = ' ';
                if (botRow == 1)
                {
                    glassSpace = '@';
                }
                Console.WriteLine("{0}*{1}@{1}*{0}",
                    new string('.', botRow),
                    new string(glassSpace, n - botRow - 1));
            }
            // bot row
            Console.WriteLine(new string('*', columns));
        }
    }
}

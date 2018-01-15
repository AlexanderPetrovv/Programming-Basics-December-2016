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
            var cols = 5 * n;
            var rows = 3 * n + 2;
            var dots = 3 * n;

            // top part
            for (int r = 0; r < n; r++)
            {
                if (r == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', n - r), new string('.', dots));
                    dots += 2;
                }
            }
            // mid row
            Console.WriteLine(new string('*', cols));
            // bot part
            for (int r = 1; r <= 2 * n; r++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', r), new string('.', cols - 2 * r - 2));
            }
            // bot row
            var botRowDots = 2 * n + 1;
            Console.WriteLine("{0}{1}{0}", new string('.', botRowDots), new string('*', cols - 2 * botRowDots));
        }
    }
}

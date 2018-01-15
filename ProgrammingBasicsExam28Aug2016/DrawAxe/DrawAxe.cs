using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAxe
{
    class DrawAxe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var col = 5 * n;
            // top part
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', 3 * n), 
                    new string('-', r), 
                    new string('-', 2 * n - 2 - r));
            }

            // mid part
            for (int r = 0; r < n / 2; r++)
            {
                Console.WriteLine("{0}*{1}*{1}",
                    new string('*', 3 * n), 
                    new string('-', n - 1));
            }

            // bot part
            for (int r = 0; r < n / 2; r++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', 3 * n - r), 
                    r != n / 2 - 1 ? new string('-', n - 1 + 2 * r) : new string('*', n - 1 + 2 * r), 
                    new string('-', n - 1 - r));
            }
        }
    }
}

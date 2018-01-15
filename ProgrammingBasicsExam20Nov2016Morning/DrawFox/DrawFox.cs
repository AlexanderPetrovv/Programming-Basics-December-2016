using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFox
{
    class DrawFox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 2 * n + 3;

            // top part
            for (int r = 1; r <= n; r++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('*', r),
                    new string('-', 2 * n + 1 - 2 * r));
            }
            // mid part
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                    new string('*', (n - 1) / 2 + i),
                    new string('*', n - 2 * i));
            }
            // bot part
            for (int r = 1; r <= n; r++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', r),
                    new string('*', 2 * n + 1 - 2 * r));
            }
        }
    }
}

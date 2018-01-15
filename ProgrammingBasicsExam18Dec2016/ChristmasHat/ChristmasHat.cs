using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 4 * n + 1;
            var rows = 2 * n + 5;

            // top 2 rows
            Console.WriteLine("{0}/|\\{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));

            // mid part
            var dots = 0;
            for (int row = 0; row < 2 * n; row++)
            {
                dots = (cols - 3 - 2 * row) / 2;
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', dots),
                    new string('-', row));
            }

            // bot 3 rows
            Console.WriteLine(new string('*', cols));
            for (int c = 1; c <= cols; c++)
            {
                if (c % 2 == 0)
                    Console.Write(".");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', cols));
        }
    }
}

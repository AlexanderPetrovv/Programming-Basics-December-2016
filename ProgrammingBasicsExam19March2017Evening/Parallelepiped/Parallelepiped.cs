using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 4 * n + 4;
            var columns = 3 * n + 1;

            // first row
            Console.WriteLine("+{0}+{1}",
                new string('~', n - 2),
                new string('.', columns - n));

            // top half
            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', row),
                    new string('~', n - 2),
                    new string('.', 2 * n - row));
            }

            // bot half
            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",
                    new string('.', row),
                    new string('.', 2 * n - row),
                    new string('~', n - 2));
            }

            // last row
            Console.WriteLine("{0}+{1}+",
                new string('.', columns - n),
                new string('~', n - 2));

        }
    }
}

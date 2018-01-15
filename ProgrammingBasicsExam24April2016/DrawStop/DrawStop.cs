using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawStop
{
    class DrawStop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var col = 4 * n + 3;

            // top row
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            // top part
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', n - row), new string('_', 2 * n - 1 + 2 * row));
            }
            // mid row
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', (col - 9) / 2));
            // bot part
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', row), new string('_', col - 4 - 2 * row));
            }
        }
    }
}

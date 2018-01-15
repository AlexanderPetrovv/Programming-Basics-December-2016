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
            var dots = (width - 2) / 2; ;
            for (int rowTop = 0; rowTop < n; rowTop++)
            {
                var spaces = width - 2 * dots - 2;
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', dots),
                    new string(' ', spaces));
                dots--;
            }
            // mid row
            Console.WriteLine("{0}{1}{0}",
                new string('.', n / 2),
                new string('*', 2 * n));

            // mid part
            for (int rowMid = 0; rowMid < 2 * n; rowMid++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('.', n / 2),
                    new string('\\', 2 * n - 2));
            }

            // bot part
            for (int rowBot = n / 2; rowBot > 0; rowBot--)
            {
                var botStars = width - 2 * rowBot - 2;
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', rowBot),
                    new string('*', botStars));
            }
        }
    }
}

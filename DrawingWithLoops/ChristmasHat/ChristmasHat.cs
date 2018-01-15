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

            var width = 4 * n + 1;
            // top 2 rows
            var dots = (width - 3) / 2;
            Console.WriteLine("{0}/|\\{0}", new string('.', dots));
            Console.WriteLine("{0}\\|/{0}", new string('.', dots));

            // mid part
            for (int row = 0; row < 2 * n; row++)
            {
                Console.Write("{0}*{1}*{1}*{0}", new string('.', dots), new string('-', row));
                dots--;
                Console.WriteLine();
            }
            // bot 3 rows
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', width));
        }
    }
}

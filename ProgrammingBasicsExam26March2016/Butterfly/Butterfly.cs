using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var columns = 2 * n - 1;
            var rows = 2 * (n - 2) + 1;
            var wingSize = n - 1;
            //top
            for (int r = 1; r <= rows / 2; r++)
            {
                if (r % 2 == 1)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
            }
            //mid
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            //bot
            for (int r = 1; r <= rows / 2; r++)
            {
                if (r % 2 == 1)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
            }
        }
    }
}

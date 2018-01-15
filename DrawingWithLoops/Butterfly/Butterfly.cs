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

            // Upper wings
            for (int rowUp = 1; rowUp <= n - 2; rowUp++)
            {
                if (rowUp % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
            }
            // Mid part/body
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            // Lower wings
            for (int rowBottom = 1; rowBottom <= n - 2; rowBottom++)
            {
                if (rowBottom % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
            }
        }
    }
}

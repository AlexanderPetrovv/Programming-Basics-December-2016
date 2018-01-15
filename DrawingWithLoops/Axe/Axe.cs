using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 5 * n;
            // top section
            for (int topRow = 0; topRow < n; topRow++)
            {
                Console.WriteLine("{0}*{1}*{2}", 
                    new string('-', 3 * n), 
                    new string('-', topRow), 
                    new string('-', 2 * n - 2 - topRow));
            }

            // mid section
            for (int midRow = 0; midRow < n / 2; midRow++)
            {
                Console.WriteLine("{0}{1}*{1}", 
                    new string('*', 3 * n + 1), 
                    new string('-', n - 1));
            }

            // last section
            for (int botRow = 0; botRow < n / 2; botRow++)
            {

                Console.Write(new string('-', 3 * n - botRow));
                Console.Write("*");
                if (botRow == n / 2 - 1)
                {
                    Console.Write(new string('*', n - 1 + 2 * botRow));
                }
                else
                {
                    Console.Write(new string('-', n - 1 + 2 * botRow));
                }
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1 - botRow)); 

            }
        }
    }
}

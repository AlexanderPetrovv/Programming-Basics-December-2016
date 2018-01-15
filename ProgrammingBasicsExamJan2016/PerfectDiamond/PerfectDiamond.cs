using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // top part
            for (int topRow = 1; topRow <= n; topRow++)
            {
                for (int topCol = 0; topCol < n - topRow; topCol++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int topCol = 1; topCol < topRow; topCol++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            // bot part
            for (int botRow = 1; botRow <= n - 1; botRow++)
            {
                for (int botCol = 1; botCol <= botRow; botCol++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int botCol = 1; botCol < n - botRow; botCol++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}

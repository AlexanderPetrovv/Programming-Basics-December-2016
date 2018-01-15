using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondExamVar2
{
    class DiamondExamVar2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
            for (int k = n - 1; k > 0; k--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', k), new string('.', width - 2 - 2 * k));
            }
            Console.WriteLine("{0}", new string('*', width));
            int i = 1;
            for (i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', width - 2 - 2 * i));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', width - 2 - 2 * i));
        }
    }
}

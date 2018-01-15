using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums3Numbers
{
    class Sums3Numbers
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());

            var sum = n1 + n2 + n3;
            var maxN = Math.Max(n1, Math.Max(n2, n3));
            var minN = Math.Min(n1, Math.Min(n2, n3));

            var midN = sum - maxN - minN;

            if (minN + midN == maxN)
            {
                Console.WriteLine("{0} + {1} = {2}", minN, midN, maxN);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

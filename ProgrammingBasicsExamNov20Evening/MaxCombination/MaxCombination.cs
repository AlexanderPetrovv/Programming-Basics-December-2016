using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            var beginning = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombs = int.Parse(Console.ReadLine());
            var cnt = 0;


            for (int n1 = beginning; n1 <= end; n1++)
            {
                for (int n2 = beginning; n2 <= end; n2++)
                {
                    cnt++;
                    if (cnt <= maxCombs)
                        Console.Write("<{0}-{1}>", n1, n2);
                    else
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

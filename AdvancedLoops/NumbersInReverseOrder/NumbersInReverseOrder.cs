using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReverseOrder
{
    class NumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int num = n; num >= 1; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}

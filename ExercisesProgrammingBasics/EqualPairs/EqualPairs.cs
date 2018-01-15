using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var numberPairs = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var lastSum = 0.0;
            var diff = 0.0;
            var maxDiff = 0.0;
            for (int i = 0; i < numberPairs; i++)
            {
                lastSum = sum;
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                sum = num1 + num2;
                if (i != 0)
                {
                    diff = Math.Abs(sum - lastSum);
                }

                if (maxDiff < diff)
                {
                    maxDiff = diff;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value=" + sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
        }
    }
}

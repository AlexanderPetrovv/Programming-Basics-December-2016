using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairsVariation
{
    class EqualPairsVariation
    {
        static void Main(string[] args)
        {
            var pairCount = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var lastSum = 0.0;
            var difference = 0.0;
            var maxDiff = 0.0;

            for (int i = 0; i < pairCount; i++)
            {
                var number1 = double.Parse(Console.ReadLine());
                var number2 = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    lastSum = number1 + number2;
                }
                else
                {
                    sum = number1 + number2;
                    difference = Math.Abs(sum - lastSum);

                    if (difference > maxDiff)
                    {
                        maxDiff = difference;
                    }
                    lastSum = sum;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value = " + sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + maxDiff);
            }
        }
    }
}

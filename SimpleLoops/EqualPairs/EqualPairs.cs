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
            var pairCount = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var lastSum = 0.0;
            var difference = 0.0;
            var differenceMax = 0.0;

            for (int i = 1; i <= pairCount; i++)
            {
                lastSum = sum;

                var number1 = double.Parse(Console.ReadLine());
                var number2 = double.Parse(Console.ReadLine());

                sum = number1 + number2;
                difference = Math.Abs(sum - lastSum);

                if (difference > differenceMax && i >= 2)
                {
                    differenceMax = difference;
                }
            }

            if (differenceMax == 0)
            {
                Console.WriteLine("Yes, value = " + sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + differenceMax);
            }
        }
    }
}

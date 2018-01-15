using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var maxValue = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            if ((sum / 2) == maxValue)
            {
                Console.WriteLine("Yes sum = " + maxValue);
            }
            else
            {
                var diff = Math.Abs(sum - maxValue - maxValue);
                Console.WriteLine("No diff = " + diff);
            }
        }
    }
}

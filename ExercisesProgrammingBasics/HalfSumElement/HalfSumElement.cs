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
            var maxElement = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber > maxElement)
                {
                    maxElement = inputNumber;
                }
                sum += inputNumber;
            }

            if (maxElement == sum / 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxElement);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum -  2 * maxElement));
            }
        }
    }
}

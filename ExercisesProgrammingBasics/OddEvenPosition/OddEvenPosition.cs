using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.0;

            for (int i = 1; i <= numberCount; i++)
            {
                var inputNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                    if (inputNumber > evenMax)
                    {
                        evenMax = inputNumber;
                    }

                    if (inputNumber < evenMin)
                    {
                        evenMin = inputNumber;
                    }
                }
                else
                {
                    oddSum += inputNumber;
                    if (inputNumber > oddMax)
                    {
                        oddMax = inputNumber;
                    }

                    if (inputNumber < oddMin)
                    {
                        oddMin = inputNumber;
                    }
                }
            }

            Console.WriteLine("OddSum=" + oddSum);
            Console.WriteLine(oddMin == double.MaxValue ? "OddMin=No" : "OddMin=" + oddMin);
            Console.WriteLine(oddMax == double.MinValue ? "OddMax=No" : "OddMax=" + oddMax);
            Console.WriteLine("EvenSum=" + evenSum);
            Console.WriteLine(evenMin == double.MaxValue ? "EvenMin=No" : "EvenMin=" + evenMin);
            Console.WriteLine(evenMax == double.MinValue ? "EvenMax=No" :"EvenMax=" + evenMax);
        }
    }
}

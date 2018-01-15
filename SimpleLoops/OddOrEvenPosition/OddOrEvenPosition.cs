using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class OddOrEvenPosition
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var evenSum = 0.0;

            var oddMin = double.MaxValue;
            var evenMin = double.MaxValue;

            var oddMax = double.MinValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= numberCount; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }
            Console.WriteLine("OddSum = " + oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = " + oddMin);
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = " + oddMax);
            }

            Console.WriteLine("EvenSum = " + evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = " + evenMin);
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = " + evenMax);
            }

        }
    }
}

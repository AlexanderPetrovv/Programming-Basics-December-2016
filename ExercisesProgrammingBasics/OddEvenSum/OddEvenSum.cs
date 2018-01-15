using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var oddSum = 0;
            var evenSum = 0;

            for (int i = 1; i <= numberCount; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                }
                else
                {
                    oddSum += inputNumber;
                }
            }

            var diff = Math.Abs(evenSum - oddSum);
            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}

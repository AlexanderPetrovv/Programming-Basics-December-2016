using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int number = 111111; number <= 999999; number++)
            {
                var currentNum = number;
                var currentNumDigitProduct = 1;
                while (currentNum > 0)
                {
                    var lastDigit = currentNum % 10;
                    currentNumDigitProduct *= lastDigit;
                    currentNum /= 10;
                }

                if (currentNumDigitProduct == n)
                {
                    Console.Write("{0} ", number);
                }
            }
            Console.WriteLine();
        }
    }
}

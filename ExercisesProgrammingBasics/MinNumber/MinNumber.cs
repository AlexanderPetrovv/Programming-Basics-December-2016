using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var firstNumber = double.Parse(Console.ReadLine());
            var minNumber = firstNumber;

            for (int i = 0; i < numberCount - 1; i++)
            {
                var inputNumber = double.Parse(Console.ReadLine());
                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}

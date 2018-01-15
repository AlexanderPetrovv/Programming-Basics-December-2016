using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var firstNumber = double.Parse(Console.ReadLine());
            var maxNumber = firstNumber;

            for (int i = 0; i < numberCount - 1; i++)
            {
                var inputNumber = double.Parse(Console.ReadLine());
                if (inputNumber > maxNumber)
                {
                    maxNumber = inputNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}

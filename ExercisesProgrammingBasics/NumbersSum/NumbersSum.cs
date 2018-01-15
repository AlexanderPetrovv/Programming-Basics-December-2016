using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersSum
{
    class NumbersSum
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());

            var sum = 0.0;
            for (int number = 0; number < numberCount; number++)
            {
                var inputNumber = double.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

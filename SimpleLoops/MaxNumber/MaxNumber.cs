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
            var numbers = int.Parse(Console.ReadLine());
            var maxValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }
            Console.WriteLine("Max = " + maxValue);
        }
    }
}

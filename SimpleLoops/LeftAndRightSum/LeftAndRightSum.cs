using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSum += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSum += num;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);
            }
            else
            {
                var diff = Math.Abs(firstSum - secondSum);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}

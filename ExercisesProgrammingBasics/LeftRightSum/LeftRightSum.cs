using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftsum = 0;
            var rightsum = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    leftsum += inputNumber;
                }
                else
                {
                    rightsum += inputNumber;
                }
            }

            if(leftsum == rightsum)
            {
                Console.WriteLine("Yes, sum = " + leftsum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftsum - rightsum));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var maxCount = 0;
            var lastNum = -1000;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > lastNum)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                lastNum = number;

                if (maxCount < count)
                {
                    maxCount = count;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}

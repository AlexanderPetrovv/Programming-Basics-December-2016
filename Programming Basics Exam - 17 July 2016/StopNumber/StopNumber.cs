using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var stopingNum = int.Parse(Console.ReadLine());

            for (int num = m; num >= n; num--)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    if (num == stopingNum)
                    {
                        break;
                    }
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

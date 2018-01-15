using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += (i * 2 + j * 3);
                    cnt++;
                    if (sum >= controlNum)
                    {
                        break;
                    }
                }
                if (sum >= controlNum)
                {
                    break;
                }
            }

            if (sum >= controlNum)
            {
                Console.WriteLine("{0} moves", cnt);
                Console.WriteLine("Score: {0} >= {1}", sum, controlNum);
            }
            else
            {
                Console.WriteLine("{0} moves", cnt);
            }
        }
    }
}

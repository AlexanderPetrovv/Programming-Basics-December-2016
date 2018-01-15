using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            var beginning = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var cnt = 0;
            bool isMagic = false;
            int i = 0;
            int j = 0;
            for (i = beginning; i <= end; i++)
            {
                for (j = beginning; j <= end; j++)
                {
                    cnt++;
                    if (i + j == magicNum)
                    {
                        isMagic = true;
                        break;
                    }
                }
                if (isMagic)
                {
                    break;
                }
            }

            if (isMagic)
            {
                Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", cnt, i, j, magicNum);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", cnt, magicNum);
            }
        }
    }
}

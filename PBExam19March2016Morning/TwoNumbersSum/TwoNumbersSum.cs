using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            var beginning = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var cnt = 0;
            var isMagicNum = false;
            int n1 = 0;
            int n2 = 0;
            for (n1 = beginning; n1 >= end; n1--)
            {
                for (n2 = beginning; n2 >= end; n2--)
                {
                    cnt++;
                    if (n1 + n2 == magicNum)
                    {
                        isMagicNum = true;
                        break;
                    }
                }
                if (isMagicNum)
                {
                    break;
                }
            }

            if (isMagicNum)
            {
                Console.WriteLine("Combination N:" + cnt + " ({0} + {1} = {2})", n1, n2, magicNum);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", cnt, magicNum);
            }
        }
    }
}

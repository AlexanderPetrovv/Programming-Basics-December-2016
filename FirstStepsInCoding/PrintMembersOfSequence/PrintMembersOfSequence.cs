using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMembersOfSequence
{
    class PrintMembersOfSequence
    {
        static void Main(string[] args)
        {
            int numberPrint;
            for (int i = 2; i <= 101; i++)
            {
                if (i % 2 == 0)
                {
                    numberPrint = i;
                }
                else
                {
                    numberPrint = i * (-1);
                }
                Console.WriteLine(numberPrint);
            }
        }
    }
}

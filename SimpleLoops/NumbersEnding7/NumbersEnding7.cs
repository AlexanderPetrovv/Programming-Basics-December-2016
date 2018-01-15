using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEnding7
{
    class NumbersEnding7
    {
        static void Main(string[] args)
        {
            for (var number = 1; number <= 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

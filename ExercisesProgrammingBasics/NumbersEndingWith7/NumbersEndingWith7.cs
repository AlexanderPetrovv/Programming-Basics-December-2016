using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingWith7
{
    class NumbersEndingWith7
    {
        static void Main(string[] args)
        {
            for (int number = 7; number <= 1000; number += 10)
            {
                Console.WriteLine(number);
            }
        }
    }
}

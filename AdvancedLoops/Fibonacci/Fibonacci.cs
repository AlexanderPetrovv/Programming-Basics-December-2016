﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var f1 = 1;
            var f2 = 1;

            for (int i = 0; i < n - 2; i++)
            {
                var fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
            Console.WriteLine(f2);
        }
    }
}

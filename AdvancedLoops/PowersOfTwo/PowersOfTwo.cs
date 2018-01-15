using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
            // WORKS SLOWER!
            //for (int number = 1; number <= Math.Pow(2, n); number *= 2)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}

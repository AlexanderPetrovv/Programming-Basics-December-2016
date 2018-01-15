using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy5And7
{
    class DivideBy5And7
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            bool divisible = number % 35 == 0 ? true : false;
            Console.WriteLine("Number divisible by 5 and 7: {0}", divisible);
        }
    }
}

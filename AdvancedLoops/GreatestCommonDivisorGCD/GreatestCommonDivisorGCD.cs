using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisorGCD
{
    class GreatestCommonDivisorGCD
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var temporary = b;
                b = a % b;
                a = temporary;
            }
            Console.WriteLine(a);
        }
    }
}

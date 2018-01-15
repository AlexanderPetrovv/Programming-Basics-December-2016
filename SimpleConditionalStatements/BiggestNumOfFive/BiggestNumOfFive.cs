using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumOfFive
{
    class BiggestNumOfFive
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var e = double.Parse(Console.ReadLine());

            if (a < b)
            {
                a = b;
            }
            if (a < c)
            {
                a = c;
            }
            if (a < d)
            {
                a = d;
            }
            if (a < e)
            {
                a = e;
            }
            Console.WriteLine(a);
        }
    }
}

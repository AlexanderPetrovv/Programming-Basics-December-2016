using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNums
{
    class SortNums
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());  //a = 5  EXAMPLE!!!
            var b = double.Parse(Console.ReadLine());  //b = 7
            var c = double.Parse(Console.ReadLine());  //c = 9
            double temporary = 0;

            if (b > a)
            {
                temporary = a; //temporary = 5
                a = b; //a = 7
                b = temporary; //b = 5
            }

            if (c > a)
            {
                temporary = a; //temporary = 7
                a = c; //a = 9
                c = temporary; //c = 7
            }

            if (c > b)
            {
                temporary = b; //temporary = 5
                b = c; //b = 7
                c = temporary; //c = 5
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
    }
}

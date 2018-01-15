using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 1;
            for (int num = 0; num <= n; num += 2)               // or for (int num = 0; num <= n / 2; num++)
            {
                Console.WriteLine(result);
                result = result * 4;
            }
        }
    }
}

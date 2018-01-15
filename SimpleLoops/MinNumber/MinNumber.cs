using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var minValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < count - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < minValue)
                {
                    minValue = num;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var profit = 0.0;

            if (projection == "premiere")
            {
                profit = rows * columns * 12;
            }
            else if (projection == "normal")
            {
                profit = rows * columns * 7.5;
            }
            else if (projection == "discount")
            {
                profit = rows * columns * 5;
            }
            Console.WriteLine("{0:f2} leva", profit);
        }
    }
}

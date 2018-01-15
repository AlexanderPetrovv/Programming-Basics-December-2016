using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var colSize = n / 2;
            var midPart = 2 * n - 4 - 2 * colSize;
            // top
            Console.Write("/");
            Console.Write(new string('^', colSize));
            Console.Write("\\");
            Console.Write(new string('_', midPart));
            Console.Write("/");
            Console.Write(new string('^', colSize));
            Console.WriteLine("\\");
            //mid
            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write("|");
                if (row == n - 2)
                {
                    Console.Write(new string(' ', colSize + 1));
                    Console.Write(new string('_', midPart));
                    Console.Write(new string(' ', colSize + 1));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.WriteLine("|");
            }
            //bot
            Console.Write("\\");
            Console.Write(new string('_', colSize));
            Console.Write("/");
            Console.Write(new string(' ', midPart));
            Console.Write("\\");
            Console.Write(new string('_', colSize));
            Console.WriteLine("/");
        }
    }
}

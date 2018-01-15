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
            var midSize = 2 * n - 4 - 2 * colSize;
            //top part
            Console.Write("/");
            Console.Write(new string('^', colSize));
            Console.Write("\\");
            Console.Write(new string('_', midSize));
            Console.Write("/");
            Console.Write(new string('^', colSize));
            Console.WriteLine("\\");
            //middle part
            for (int mid = 0; mid < n - 3; mid++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }
            //bottom mid
            Console.Write("|");
            Console.Write(new string(' ', colSize + 1));
            Console.Write(new string('_', midSize));
            Console.Write(new string(' ', colSize + 1));
            Console.WriteLine("|");
            //bottom
            Console.Write("\\");
            Console.Write(new string('_', colSize));
            Console.Write("/");
            Console.Write(new string(' ', midSize));
            Console.Write("\\");
            Console.Write(new string('_', colSize));
            Console.WriteLine("/");
        }
    }
}

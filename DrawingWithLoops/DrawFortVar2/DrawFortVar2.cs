using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFortVar2
{
    class DrawFortVar2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var colSize = n / 2;
            var midSize = 2 * n - 4 - 2 * colSize;
            // Draw top row
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', midSize));
            // Middle rows
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }
            // Draw row before the last
            Console.WriteLine("|{0}{1}{0}|", new string(' ', colSize + 1), new string('_', midSize));
            // Draw last row
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));
        }
    }
}

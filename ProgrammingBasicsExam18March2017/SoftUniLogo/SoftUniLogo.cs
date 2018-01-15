using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 12 * n - 5;
            var rows = 4 * n - 2;

            // top part            
            var hashes = 1;
            for (int row = 1; row <= 2 * n; row++)
            {
                var dots = (columns - hashes) / 2;
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', hashes));
                hashes += 6;
            }

            // mid part
            hashes -= 6;
            for (int row = 0; row < n - 2; row++)
            {
                hashes -= 6;
                Console.WriteLine("|{0}{1}{2}",
                    new string('.', (columns - hashes) / 2 - 1),
                    new string('#', hashes),
                    new string('.', (columns - hashes) / 2));
            }

            // bot part
            hashes -= 6;
            for (int row = 0; row < n - 1; row++)
            {
                Console.WriteLine("|{0}{1}{2}",
                    new string('.', (columns - hashes) / 2 - 1),
                    new string('#', hashes),
                    new string('.', (columns - hashes) / 2));
            }
            // bot row
            Console.WriteLine("@{0}{1}{2}",
                    new string('.', (columns - hashes) / 2 - 1),
                    new string('#', hashes),
                    new string('.', (columns - hashes) / 2));
        }
    }
}

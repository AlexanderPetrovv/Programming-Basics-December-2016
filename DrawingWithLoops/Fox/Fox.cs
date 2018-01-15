using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;
            // top section
            for (int topRow = 1; topRow <= n; topRow++)
            {
                var topDash = width - 2 * topRow - 2;  
                Console.WriteLine("{0}\\{1}/{0}", new string('*', topRow), new string('-', topDash));
            }

            // mid section
            var cheek = (n - 1) / 2;                                         // cheeks = (width - 4 - n) / 2
            for (int midRow = 0; midRow < n / 3; midRow++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', cheek), new string('*', width - 2 * cheek - 4));
                cheek++;
            }
            // bottom section
            for (int topRow = 1; topRow <= n; topRow++)
            {
                var botStar = width - 2 * topRow - 2;
                Console.WriteLine("{0}\\{1}/{0}", new string('-', topRow), new string('*', botStar));
            }
        }
    }
}

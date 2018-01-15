using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign
{
    class StopSign
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // first row
            var cols = 4 * n + 3;
            var firstRowDashes = cols - 2 * (n + 1);
            Console.WriteLine(new string('.', n + 1) + new string('_', firstRowDashes) + new string('.', n + 1));
            // upper part
            var dotsUp = n;
            for (int rowUp = 0; rowUp < n; rowUp++)
            {
                var dashes = cols - 2 * dotsUp - 4;
                Console.WriteLine(new string('.', dotsUp) + "//" + new string('_', dashes) + @"\\" + new string('.', dotsUp));
                dotsUp--;
            }
            // stop row
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', (cols - 9) / 2));
            // bottom part
            for (int rowBot = 0; rowBot < n; rowBot++)
            {
                var dashes = cols - 2 * rowBot - 4;
                Console.WriteLine(new string('.', rowBot) + @"\\" + new string('_', dashes) + "//" + new string('.', rowBot));
            }
        }
    }
}

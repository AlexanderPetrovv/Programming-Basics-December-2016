using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            var n = byte.Parse(Console.ReadLine());

            // top part 
            var topDotsSIde = 2 * n;
            for (int rowTop = 0; rowTop < n; rowTop++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                    new string('~', rowTop),
                    new string('.', topDotsSIde),
                    new string('.', rowTop * 2));
                topDotsSIde -= 2;
            }

            // mid part
            var tilde = n;
            var dotsMid = 2 * n;
            var midDotsSide = 1;
            for (int rowMid = 1; rowMid <= n; rowMid++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                    new string('.', midDotsSide),
                    new string('~', tilde),
                    new string('.', dotsMid));
                tilde--;
                dotsMid -= 2;
                midDotsSide += 2;
            }
            // bot part
            Console.WriteLine("{0}####{0}", new string('.', 2 * n + 1));
            for (int rowBot = 0; rowBot < n; rowBot++)
            {
                Console.WriteLine("{0}##{0}", new string('.', 2 * n + 2));
            }
        }
    }
}

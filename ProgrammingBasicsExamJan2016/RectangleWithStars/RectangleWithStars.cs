using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var midPart = n;
            if (n % 2 == 0)
            {
                midPart = n - 1;
            }

            Console.WriteLine(new string('%', 2 * n));
            for (int i = 0; i < midPart; i++)
            {
                Console.Write("%");
                if (i == midPart / 2)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.WriteLine("%");
            }
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}

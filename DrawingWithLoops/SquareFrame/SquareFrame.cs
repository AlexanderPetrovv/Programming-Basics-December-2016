using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                var symbol = "|";
                if (row == 1 || row == n)
                {
                    symbol = "+";
                }
                Console.Write(symbol);

                if (n > 1)
                {
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write(" ");
                        Console.Write("-");
                    }
                    Console.Write(" " + symbol);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrameVar2
{
    class SquareFrameVar2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");

            if (n == 1)
            {
                Console.WriteLine();
            }
            else
            {
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");

                for (int row = 0; row < n - 2; row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
                }

                Console.Write("+");
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
        }
    }
}

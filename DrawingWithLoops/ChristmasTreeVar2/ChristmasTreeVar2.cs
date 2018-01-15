using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTreeVar2
{
    class ChristmasTreeVar2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int leftSpace = 0; leftSpace < n - row; leftSpace++)
                {
                    Console.Write(" ");
                }

                for (int leftStars = 0; leftStars < row; leftStars++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int rightStars = 0; rightStars < row; rightStars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

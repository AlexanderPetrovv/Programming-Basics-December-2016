using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondExam
{
    class DiamondExam
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var height = 3 * n + 2;
            var leftRightDots = n;
            var middleDots = width - 2 * leftRightDots;

            // top section
            for (int rowTop = 0; rowTop < n; rowTop++)
            {
                if (rowTop == 0)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', leftRightDots),
                        new string('*', middleDots));
                }
                else
                {
                    leftRightDots--;
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', leftRightDots),
                        new string('.', middleDots));
                    middleDots += 2;
                }
            }

            Console.WriteLine(new string('*', 5 * n));

            // bottom section
            middleDots -= 2;
            for (int rowBot = 0; rowBot < 2 * n + 1; rowBot++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', leftRightDots),
                    new string(rowBot == 2 * n ? '*' : '.', middleDots));
                leftRightDots++;
                middleDots -= 2;
            }
        }
    }
}

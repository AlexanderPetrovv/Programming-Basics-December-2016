using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var thirdDigit = num % 10;
            var secondDigit = (num / 10) % 10;
            var firstDigit = num / 100;
            var rows = firstDigit + secondDigit;
            var cols = firstDigit + thirdDigit;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= firstDigit;
                        Console.Write(num + " ");
                    }
                    else if (num % 3 == 0)
                    {
                        num -= secondDigit;
                        Console.Write(num + " ");
                    }
                    else
                    {
                        num += thirdDigit;
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

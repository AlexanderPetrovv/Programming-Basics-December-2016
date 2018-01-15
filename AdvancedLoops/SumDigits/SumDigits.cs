using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            var digitSum = 0;

            do
            {
                digitSum = digitSum + (num % 10);
                num = num / 10;
            } while (num > 0);
            Console.WriteLine(digitSum);
        }
    }
}

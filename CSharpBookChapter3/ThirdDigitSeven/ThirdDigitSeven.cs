using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitSeven
{
    class ThirdDigitSeven
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            //bool check = (number / 100) % 10 == 7 ? true : false;
            //Console.WriteLine("Third digit 7: " + check);
            Console.WriteLine((number / 100) % 10 == 7 ? "Third digit is 7" : "Third digit is NOT 7");
        }
    }
}

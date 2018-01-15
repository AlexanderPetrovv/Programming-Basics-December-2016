using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumManipulation
{
    class FourDigitNumManipulation
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var a = number / 1000;
            var b = (number / 100) % 10;
            var c = (number / 10) % 10;
            var d = number % 10;

            Console.WriteLine(a + " " + b + " " + c + " " + d);
            Console.WriteLine("Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("Digits in reverse order = " + d + c + b + a); // d * 1000 + c * 100 + b * 10 + a
            Console.WriteLine("Last digit first = " + d + a + b + c);  // d * 1000 + a * 100 + b * 10 + c 
            Console.WriteLine("Swap 2nd and 3rd digit = " + a + c + b + d);  // a * 1000 + c * 100 + b * 10 + d
        }
    }
}

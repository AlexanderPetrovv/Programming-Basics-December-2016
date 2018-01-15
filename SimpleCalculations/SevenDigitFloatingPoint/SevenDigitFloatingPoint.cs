using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenDigitFloatingPoint
{
    class SevenDigitFloatingPoint
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            a += b;      //a = a + b
            Console.WriteLine(a.ToString("#.######"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity
{
    class Gravity
    {
        static void Main(string[] args)
        {
            Console.Write("Weight on Earth = ");
            var weight = double.Parse(Console.ReadLine());
            Console.Write("Weight on Moon = ");
            Console.WriteLine(weight * 0.17);
        }
    }
}

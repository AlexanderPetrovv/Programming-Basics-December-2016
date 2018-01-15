using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1To100
{
    class NumberInRange1To100
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            var n = -1;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number!");
                }
                catch
                {
                    Console.WriteLine("This is not a number!");
                }
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}

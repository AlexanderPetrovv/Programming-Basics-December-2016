using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperationsVariation
{
    class NumberOperationsVariation
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.Write($"{n1} + {n2} = {n1 + n2} - ");  // ("{0} + {1} = {2} - ", n1, n2, n1 + n2)
                Console.WriteLine((n1 + n2)% 2 == 0 ? "even" : "odd");
            }
            else if (operation == "-")
            {
                Console.Write($"{n1} - {n2} = {n1 - n2} - ");  // ("{0} - {1} = {2} - ", n1, n2, n1 - n2)
                Console.WriteLine((n1 - n2) % 2 == 0 ? "even" : "odd");
            }
            else if (operation == "*")
            {
                Console.Write($"{n1} * {n2} = {n1 * n2} - ");  // ("{0} * {1} = {2} - ", n1, n2, n1 * n2)
                Console.WriteLine((n1 * n2) % 2 == 0 ? "even" : "odd");
            }
            else if (operation == "/")
            {
                Console.WriteLine(n2 == 0
                    ? $"Cannot divide {n1} by zero"  // "Cannot divide {0} by zero", n1
                    : $"{n1} / {n2} = {(double)n1 / n2}");  //"{0} / {1} = {2}", n1, n2, (double)n1 / n2
            }
            else if (operation == "%")
            {
                Console.WriteLine(n2 == 0
                    ? "Cannot divide {0} by zero"
                    : "{0} % {1} = {2}", n1, n2, (double)n1 % n2);
            }
        }
    }
}

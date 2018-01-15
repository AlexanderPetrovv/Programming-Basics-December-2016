using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    class NumberOperations
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());

            var result = 0.0;

            if (symbol == '/' || symbol == '%')
            {
                if (n2 != 0)
                {
                    switch (symbol)
                    {
                        case '/':
                            result = n1 / n2;
                            Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                            break;
                        case '%':
                            result = n1 % n2;
                            Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
            }
            else
            {
                switch (symbol)
                {
                    case '+': result = n1 + n2; break;
                    case '-': result = n1 - n2; break;
                    case '*': result = n1 * n2; break;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                }
            }
        }
    }
}

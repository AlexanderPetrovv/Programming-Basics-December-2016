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
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var operation = char.Parse(Console.ReadLine());
            var result = 0.0;
            var oddEven = "";

            if (operation == '+')
            {
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, operation, secondNumber, result, oddEven);
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, operation, secondNumber, result, oddEven);
            }
            else if (operation == '*')
            {
                result = firstNumber * secondNumber;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, operation, secondNumber, result, oddEven);
            }
            else if (operation == '/')
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", firstNumber, operation, secondNumber, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }            
            }
            else if (operation == '%')
            {
                if (secondNumber != 0)
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }       
            }
        }
    }
}

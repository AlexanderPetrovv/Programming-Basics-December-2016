using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueSwap
{
    class ValueSwap
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            var secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
            }
            Console.WriteLine("First number is {0}, and second number is {1}", firstNumber, secondNumber);
        }
    }
}

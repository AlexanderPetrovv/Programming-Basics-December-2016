using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbersWithLoop
{
    class SumNumbersWithLoop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you would like to sum: ");
            var numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter {0} numbers, one on each row!", numbers);
            var sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                var input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}

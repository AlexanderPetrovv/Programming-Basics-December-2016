using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            var steps = int.Parse(Console.ReadLine());

            var result = 0.0;
            var fromZeroToNine = 0;
            var fromTenToNineteen = 0;
            var fromTwentyToTwentynine = 0;
            var fromThirtyToThirtynine = 0;
            var fromFourtyToFifty = 0;
            var invalidNums = 0;

            for (int i = 1; i <= steps; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    result /= 2;
                    invalidNums++;
                }
                else if (number <= 9)
                {
                    result += number * 0.2;
                    fromZeroToNine++;
                }
                else if (number <= 19)
                {
                    result += number * 0.3;
                    fromTenToNineteen++;
                }
                else if (number <= 29)
                {
                    result += number * 0.4;
                    fromTwentyToTwentynine++;
                }
                else if (number <= 39)
                {
                    result += 50;
                    fromThirtyToThirtynine++;
                }
                else if (number <= 50)
                {
                    result += 100;
                    fromFourtyToFifty++;
                }
            }

            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", fromZeroToNine * 100.0 / steps);
            Console.WriteLine("From 10 to 19: {0:f2}%", fromTenToNineteen * 100.0 / steps);
            Console.WriteLine("From 20 to 29: {0:f2}%", fromTwentyToTwentynine * 100.0 / steps);
            Console.WriteLine("From 30 to 39: {0:f2}%", fromThirtyToThirtynine * 100.0 / steps);
            Console.WriteLine("From 40 to 50: {0:f2}%", fromFourtyToFifty * 100.0 / steps);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidNums * 100.0 / steps);
        }
    }
}

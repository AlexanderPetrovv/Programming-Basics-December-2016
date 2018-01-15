using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var firstPipe = int.Parse(Console.ReadLine());
            var secondPipe = int.Parse(Console.ReadLine());
            var timeMissing = double.Parse(Console.ReadLine());

            var f1Water = firstPipe * timeMissing;
            var f2Water = secondPipe * timeMissing;
            var totalWater = f1Water + f2Water;

            if (poolVolume >= totalWater)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    Math.Truncate(totalWater / poolVolume * 100), 
                    Math.Truncate(f1Water / totalWater * 100), 
                    Math.Truncate(f2Water / totalWater * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", timeMissing, totalWater - poolVolume);
            }
        }
    }
}

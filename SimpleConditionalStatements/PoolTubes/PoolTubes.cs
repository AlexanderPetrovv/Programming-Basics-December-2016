using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolTubes
{
    class PoolTubes
    {
        static void Main(string[] args)
        {
            var poolVolume = double.Parse(Console.ReadLine());
            var tube1 = double.Parse(Console.ReadLine());
            var tube2 = double.Parse(Console.ReadLine());
            var time = double.Parse(Console.ReadLine());

            var tubeOneTotal = tube1 * time;
            var tubeTwoTotal = tube2 * time;
            var totalQuantity = tubeOneTotal + tubeTwoTotal;

            if (totalQuantity <= poolVolume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(totalQuantity / poolVolume * 100), Math.Truncate(tubeOneTotal / totalQuantity * 100), Math.Truncate(tubeTwoTotal / totalQuantity * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, (totalQuantity - poolVolume));
            }
        }
    }
}

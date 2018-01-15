using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var upper = (n + 1) / 2;
            var lower = n - upper;            // n - (n + 1) / 2 works as n / 2
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            var dash = (n - stars) / 2;
            //upper part
            for (int upperRow = 0; upperRow < upper; upperRow++)
            {
                Console.Write(new string('-', dash));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', dash));
                stars += 2;
                dash--;
            }
            //lower part
            for (int lowerRow = 0; lowerRow < lower; lowerRow++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}

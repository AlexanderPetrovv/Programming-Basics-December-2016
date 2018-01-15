using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var kilometres = int.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine().ToLower();

            if (kilometres < 20)
            {
                if(dayNight == "day")
                {
                    Console.WriteLine(kilometres * 0.79 + 0.70);
                }
                else
                {
                    Console.WriteLine(kilometres * 0.90 + 0.70);
                }
            }
            else if (kilometres < 100)
            {
                Console.WriteLine(kilometres * 0.09);
            }
            else
            {
                Console.WriteLine(kilometres * 0.06);
            }
        }
    }
}

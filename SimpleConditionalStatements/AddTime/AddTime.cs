using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTime
{
    class AddTime
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var sum = ((hours * 60) + minutes + 15);
            var newHour = sum / 60;
            if (newHour >= 24)
            {
                newHour -= 24;
            }
            var newMinutes = sum % 60;

            Console.WriteLine("{0}:{1:00}", newHour, newMinutes);
        }
    }
}

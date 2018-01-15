using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTimeVar
{
    class AddTimeVar
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var addTime = 15;
            minutes = minutes + addTime;

            if (minutes >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 60;
            }
            if (hours > 23)
            {
                hours = hours % 24;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hours + ":0" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }          
        }
    }
}

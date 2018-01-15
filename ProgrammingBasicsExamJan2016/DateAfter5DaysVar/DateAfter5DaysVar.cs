using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5DaysVar
{
    class DateAfter5DaysVar
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var daysToAdd = 5;
            day += daysToAdd;
            var daysOfMonth = 31;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysOfMonth = 30;
            }
            else if (month == 2)
            {
                daysOfMonth = 28;
            }

            if (day > daysOfMonth)
            {
                day -= daysOfMonth;
                month++;
                if (month > 12)
                {
                    month -= 12;
                }
            }

            Console.WriteLine("{0}.{1:00}", day, month);
        }
    }
}

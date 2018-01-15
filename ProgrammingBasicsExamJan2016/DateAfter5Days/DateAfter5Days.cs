using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var daysToAdd = 5;

            if (month == 2)
            {
                if (days + daysToAdd > 28)
                {
                    month++;
                    days = days + daysToAdd - 28;
                }
                else
                {
                    days = days + daysToAdd;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (days + daysToAdd > 30)
                {
                    month++;
                    days = days + daysToAdd - 30;
                }
                else
                {
                    days = days + daysToAdd;
                }
            }
            else
            {
                if (days + daysToAdd > 31)
                {
                    month++;
                    days = days + daysToAdd - 31;
                }
                else
                {
                    days = days + daysToAdd;
                }
            }

            if (month > 12)
            {
                month -= 12;
            }

            Console.WriteLine("{0}.{1:00}", days, month);
        }
    }
}

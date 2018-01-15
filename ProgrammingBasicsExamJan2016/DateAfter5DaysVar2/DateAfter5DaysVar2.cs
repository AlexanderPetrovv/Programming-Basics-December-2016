using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5DaysVar2
{
    class DateAfter5DaysVar2
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var daysToAdd = 5;

            var year = 2017;

            DateTime firstDate = new DateTime(year, month, days);
            DateTime secondDate = firstDate.AddDays(daysToAdd);
            Console.WriteLine(secondDate.ToString("d.MM"));
        }
    }
}

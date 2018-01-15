using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            var examTime = examHour * 60 + examMinute;
            var arrivalTime = arrivalHour * 60 + arrivalMinute;
            var diff = examTime - arrivalTime;

            if (diff < 0)
            {
                Console.WriteLine("Late");
                if (diff <= -60)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", -diff / 60, -diff % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(diff));
                }
            }
            else if (diff <= 30)              // >= 0 and <= 30
            {
                if (diff == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", diff);
                }
            }
            else                            // > 30
            {
                Console.WriteLine("Early");
                if (diff < 60)
                {
                    Console.WriteLine("{0} minutes before the start", diff);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", diff / 60, diff % 60);
                }
            }
        }
    }
}

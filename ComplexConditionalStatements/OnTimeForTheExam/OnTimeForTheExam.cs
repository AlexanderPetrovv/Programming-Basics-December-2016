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

            var examTimeMins = examHour * 60 + examMinute;
            var arrivalTimeMins = arrivalHour * 60 + arrivalMinute;
            var timeDifference = arrivalTimeMins - examTimeMins;

            if (timeDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (timeDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else 
            {
                Console.WriteLine("Late");
            }

            if (timeDifference != 0)
            {
                var hours = Math.Abs(timeDifference / 60);
                var minutes = Math.Abs(timeDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                {
                    Console.Write(minutes + " minutes");
                }

                if (timeDifference < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
        }
    }
}

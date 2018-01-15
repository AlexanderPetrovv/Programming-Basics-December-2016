using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transportation = Console.ReadLine();
            var nightPrice = 82.99;

            var adultPrice = 0.0;
            var studentPrice = 0.0;

            if (transportation.ToLower() == "train")
            {
                adultPrice = 24.99;
                studentPrice = 14.99;
                if (adults + students > 50)
                {
                    adultPrice *= 0.5;
                    studentPrice *= 0.5;
                }
            }
            else if (transportation.ToLower() == "bus")
            {
                adultPrice = 32.5;
                studentPrice = 28.5;
            }
            else if (transportation.ToLower() == "boat")
            {
                adultPrice = 42.99;
                studentPrice = 39.99;
            }
            else if (transportation.ToLower() == "airplane")
            {
                adultPrice = 70.0;
                studentPrice = 50.0;
            }

            var totalExpenses = 2 * adultPrice * adults + 2 * studentPrice * students + nightPrice * nights;
            var afterComission = 1.1 * totalExpenses;
            Console.WriteLine("{0:f2}", afterComission);
        }
    }
}

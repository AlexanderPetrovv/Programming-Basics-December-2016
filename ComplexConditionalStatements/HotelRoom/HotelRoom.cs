using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = double.Parse(Console.ReadLine());

            var apartmentPrice = 0.0;
            var studioPrice = 0.0;

            if (month == "may" || month == "october")
            {
                if (nights > 14)
                {
                    studioPrice = 50.0 - 50.0 * 0.3;
                    apartmentPrice = 65.0 - 65.0 * 0.1;
                }
                else if (nights > 7)
                {
                    studioPrice = 50.0 - 50.0 * 0.05;
                    apartmentPrice = 65.0;
                }
                else
                {
                    studioPrice = 50.0;
                    apartmentPrice = 65.0;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    studioPrice = 75.2 - 75.2 * 0.2;
                    apartmentPrice = 68.7 - 68.7 * 0.1;
                }
                else
                {
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                }
            }
            else if (month == "july" || month == "august")
            {
                if (nights > 14)
                {
                    studioPrice = 76.0;
                    apartmentPrice = 77.0 - 77.0 * 0.1;
                }
                else 
                {
                    studioPrice = 76.0;
                    apartmentPrice = 77.0;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", nights * apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", nights * studioPrice);
        }
    }
}

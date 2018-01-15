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
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month.ToLower() == "may" || month.ToLower() == "october")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (nights > 14)
                {
                    studioPrice = 0.7 * 50;
                    apartmentPrice = 0.9 * 65;
                }
                else if (nights > 7)
                {
                    studioPrice = 0.95 * 50;
                }               
            }
            else if (month.ToLower() == "june" || month.ToLower() == "september")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.7;
                if (nights > 14)
                {
                    studioPrice = 0.8 * 75.2;
                    apartmentPrice = 0.9 * 68.7;
                }            
            }
            else if (month.ToLower() == "july" || month.ToLower() == "august")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (nights > 14)
                {
                    apartmentPrice = 0.9 * 77;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice * nights);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nights);
        }
    }
}

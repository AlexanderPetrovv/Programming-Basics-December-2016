using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var heritage = double.Parse(Console.ReadLine());
            var yearToLiveTo = int.Parse(Console.ReadLine());
            var moneySpent = 0.0;
            var age = 18;

            for (int year = 1800; year <= yearToLiveTo; year++)
            {
                if (year % 2 == 0)
                {
                    moneySpent += 12000;
                }
                else
                {
                    moneySpent += 12000 + 50 * age;
                }
                age++;
            }

            if (moneySpent <= heritage)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage - moneySpent);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", moneySpent - heritage);
            }
        }
    }
}

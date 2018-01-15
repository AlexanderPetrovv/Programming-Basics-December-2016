using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMyAgeIn10Years
{
    class PrintMyAgeIn10Years
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;
            DateTime futureDate = DateTime.Now.AddYears(10);
            int ageInTenYears = futureDate.Year - birthYear;
            Console.WriteLine("Your age in 10 years will be:{0}", ageInTenYears);
        }
    }
}

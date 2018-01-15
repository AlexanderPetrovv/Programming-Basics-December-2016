using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine().ToLower();

            if (age < 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Master");
                }
                else // sex == "f"
                {
                    Console.WriteLine("Miss");
                }
            }
            else  // age >= 16
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else // sex == "f"
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}

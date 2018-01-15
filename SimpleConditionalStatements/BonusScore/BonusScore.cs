using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = int.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (score <= 100)
            {
                bonus = bonus + 5;
            }
            else if (score <= 1000)
            {
                bonus = bonus + score * 0.2;
            }
            else
            {
                bonus = bonus + score * 0.1;
            }

            if (score % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (score % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine("Bonus score: " + bonus);
            Console.WriteLine("Total score: " + (bonus + score));
        }
    }
}

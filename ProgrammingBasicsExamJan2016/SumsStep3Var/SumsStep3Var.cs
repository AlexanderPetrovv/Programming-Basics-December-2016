using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsStep3Var
{
    class SumsStep3Var
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int counter1 = 1;
            int counter2 = 2;
            int counter3 = 3;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i == counter1)
                {
                    counter1 += 3;
                    sum1 += number;
                }
                else if (i == counter2)
                {
                    counter2 += 3;
                    sum2 += number;
                }
                else if (i == counter3)
                {
                    counter3 += 3;
                    sum3 += number;
                }
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}

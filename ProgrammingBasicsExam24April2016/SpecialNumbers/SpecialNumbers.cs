using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int n1 = 1; n1 <= 9; n1++)
            {
                for (int n2 = 1; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 1; n4 <= 9; n4++)
                        {
                            if (number % n1 == 0 && number % n2 == 0 && number % n3 == 0 && number % n4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", n1, n2, n3, n4);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

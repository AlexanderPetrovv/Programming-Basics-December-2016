using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55StarsWithTwoFors
{
    class TriangleOf55StarsWithTwoFors
    {
        static void Main(string[] args)
        {
            char asterisk = '*';
            for (int rowNum = 1; rowNum <= 10; rowNum++)
            {
                for (int asteriskNum = 1; asteriskNum <= rowNum; asteriskNum++)
                {
                    Console.Write(asterisk);
                }
                Console.WriteLine();
            }
        }
    }
}
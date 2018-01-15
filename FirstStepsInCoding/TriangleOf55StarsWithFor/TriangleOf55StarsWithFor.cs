using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55StarsWithFor
{
    class TriangleOf55StarsWithFor
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 10; row++)
            {               
                Console.WriteLine(new string('*', row));
            }
        }
    }
}
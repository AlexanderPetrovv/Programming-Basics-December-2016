using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfRandomStars
{
    class TriangleOfRandomStars
    {
        static void Main(string[] args)
        {
            char constructingElement = '*';

            Console.WriteLine("Enter the number of" + constructingElement + ": ");
            string nStr = Console.ReadLine();
            int n;
            int.TryParse(nStr, out n);

            int row = 0;
            while (n > 0)
            {
                row++;
                if (n < row) row = n;
                Console.WriteLine(new String(constructingElement, row));
                n -= row;
            }

            Console.ReadLine();
        }
    }
}

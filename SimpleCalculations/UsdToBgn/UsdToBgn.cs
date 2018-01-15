using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgn
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine("BGN = {0}", Math.Round(bgn, 2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuanAmount = double.Parse(Console.ReadLine());
            var taxIndex = double.Parse(Console.ReadLine());
            var euro = ((bitcoins * 1168) / 1.95) + (yuanAmount * 0.15 * 1.76 / 1.95);
            var taxAmount = euro * taxIndex / 100;
            var result = euro - taxAmount;
            Console.WriteLine(result);
        }
    }
}

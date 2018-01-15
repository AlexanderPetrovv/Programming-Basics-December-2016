using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            decimal vegPrice = decimal.Parse(Console.ReadLine());
            decimal fruitPrice = decimal.Parse(Console.ReadLine());
            int vegWeight = int.Parse(Console.ReadLine());
            int fruitWeight = int.Parse(Console.ReadLine());
            decimal euroRate = 1.94m;
            Console.WriteLine((vegPrice / euroRate * vegWeight) + (fruitPrice / euroRate * fruitWeight));
        }
    }
}

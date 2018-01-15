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
            var vegPrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegKg = int.Parse(Console.ReadLine());
            var fruitKg = int.Parse(Console.ReadLine());

            var vegIncome = vegPrice * vegKg;
            var fruitIncome = fruitPrice * fruitKg;
            var totalIncome = vegIncome + fruitIncome;
            var euro = 1.94;
            Console.WriteLine(totalIncome / euro);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            var vineyardArea = double.Parse(Console.ReadLine());
            var kilosSquareMeter = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());

            var totalGrape = vineyardArea * kilosSquareMeter;
            var afterWaste = totalGrape - waste;

            var grapeForRakia = 0.45 * afterWaste;
            var grapeForSale = afterWaste - grapeForRakia;
            var rakia = grapeForRakia / 7.5;

            var rakiaIncome = rakia * 9.8;
            var grapeIncome = grapeForSale * 1.5;

            Console.WriteLine("{0:f2}", rakiaIncome);
            Console.WriteLine("{0:f2}", grapeIncome);
        }
    }
}

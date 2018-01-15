using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            var collectedMoney = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorLength = double.Parse(Console.ReadLine());
            var triangleSide = double.Parse(Console.ReadLine());
            var trinagleHeight = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var workerMoney = double.Parse(Console.ReadLine());

            var floorArea = floorWidth * floorLength;
            var tileArea = triangleSide * trinagleHeight / 2.0;
            var tilesNeeded = Math.Ceiling(floorArea / tileArea + 5);
            var totalExpenses = tilesNeeded * tilePrice + workerMoney;

            if (totalExpenses <= collectedMoney)
            {
                Console.WriteLine("{0:f2} lv left.", collectedMoney - totalExpenses);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", totalExpenses - collectedMoney);
            }
        }
    }
}

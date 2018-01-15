using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair
{
    class TileRepair
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLength = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLength = double.Parse(Console.ReadLine());
            var timePerTile = 0.2;
            var tileNumber = ((side * side) - (benchWidth * benchLength)) / (tileWidth * tileLength);
            Console.WriteLine(tileNumber);
            var time = tileNumber * timePerTile;
            Console.WriteLine(time);
        }
    }
}

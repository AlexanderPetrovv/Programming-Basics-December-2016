using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            var sideALength = double.Parse(Console.ReadLine());
            var houseHeight = double.Parse(Console.ReadLine());

            var sideArea = (sideALength * (sideALength / 2.0)) * 2;
            var backArea = (sideALength / 2.0) * (sideALength / 2.0) + ((sideALength / 2.0) * (houseHeight - sideALength / 2.0) / 2.0);
            var frontArea = backArea - (sideALength / 5.0) * (sideALength / 5.0);
            var roofArea = (sideALength * sideALength / 2.0) * 2;          // Equal to sideArea

            var greenPaintArea = sideArea + backArea + frontArea;
            var redPaintArea = roofArea;

            var greenPaint = greenPaintArea / 3;
            var redPaint = redPaintArea / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}

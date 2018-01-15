using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            double front = double.Parse(Console.ReadLine());
            double sideLength = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double doorArea = 1.2 * 2;
            double windowArea = 1.5 * 1.5;
            double sideArea = front * sideLength;
            double frontArea = front * front;

            double roofSideArea = front * sideLength;
            double triangleArea = front * triangleHeight / 2.0;

            double greenPaintArea = frontArea + (frontArea - doorArea) + 2 * (sideArea - windowArea);
            double greenPaint = greenPaintArea / 3.4;
            double redPaintArea = roofSideArea * 2 + triangleArea * 2;
            double redPaint = redPaintArea / 4.3;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}

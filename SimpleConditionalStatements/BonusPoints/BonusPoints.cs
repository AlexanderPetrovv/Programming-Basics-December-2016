using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    points = points * 10;
                    Console.WriteLine(points);
                    break;
                case 4:
                case 5:
                case 6:
                    points = points * 100;
                    Console.WriteLine(points);
                    break;
                case 7:
                case 8:
                case 9:
                    points = points * 1000;
                    Console.WriteLine(points);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}

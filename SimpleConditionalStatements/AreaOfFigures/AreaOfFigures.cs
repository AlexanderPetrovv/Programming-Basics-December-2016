using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if (figure == "rectangle")
            {
                var sidea = double.Parse(Console.ReadLine());
                var sideb = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(sidea * sideb, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((radius * radius) * Math.PI, 3));
            }
            else if (figure == "triangle")
            {
                var triangleSide = double.Parse(Console.ReadLine());
                var trinagleHeight = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(triangleSide * trinagleHeight / 2, 3));
            }
            else
            {
                Console.WriteLine("Not a figure from the list.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var cartVolume = double.Parse(Console.ReadLine());

            var courses = 0.0;
            courses = Math.Ceiling(bricks / (cartVolume * workers));
            Console.WriteLine(courses);
        }
    }
}

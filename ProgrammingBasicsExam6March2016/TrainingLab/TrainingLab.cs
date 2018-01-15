using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var columns = Math.Truncate((w * 100) / 120);
            var rows = Math.Truncate((h * 100 - 100) / 70);
            var tables = columns * rows - 3;
            Console.WriteLine(tables);
        }
    }
}

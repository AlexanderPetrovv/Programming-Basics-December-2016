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
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            if (3<=w && w<=h && h<=100)
            {
                double seatRows = Math.Truncate((h * 100) / 120);
                double seatColumns = Math.Truncate(((w * 100) - 100) / 70);
                double seatCount = seatRows * seatColumns - 3;
                Console.WriteLine(seatCount);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}

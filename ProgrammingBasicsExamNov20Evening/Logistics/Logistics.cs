using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var loads = int.Parse(Console.ReadLine());

            var microbusPrice = 200.0;
            var truckPrice = 175.0;
            var trainPrice = 120.0;

            var microbusCnt = 0;
            var truckCnt = 0;
            var trainCnt = 0;

            for (int l = 0; l < loads; l++)
            {
                var weight = int.Parse(Console.ReadLine());
                if (weight <= 3)
                {
                    microbusCnt += weight;
                }
                else if (weight <= 11)
                {
                    truckCnt += weight;
                }
                else
                {
                    trainCnt += weight;
                }
            }

            var totalLoads = microbusCnt + truckCnt + trainCnt;
            var averagePrice = (microbusCnt * microbusPrice + truckCnt * truckPrice + trainCnt * trainPrice) / totalLoads;

            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine("{0:f2}%", microbusCnt * 100.0 / totalLoads);
            Console.WriteLine("{0:f2}%", truckCnt * 100.0 / totalLoads);
            Console.WriteLine("{0:f2}%", trainCnt * 100.0 / totalLoads);
        }
    }
}

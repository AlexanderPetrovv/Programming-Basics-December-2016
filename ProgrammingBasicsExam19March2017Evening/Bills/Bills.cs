using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            var waterPrice = 20;
            var internetPrice = 15;
            var electricTotal = 0.0;
            var otherTotal = 0.0;

            for (int m = 0; m < months; m++)
            {
                var electricBill = double.Parse(Console.ReadLine());
                electricTotal += electricBill;
                otherTotal += (waterPrice + internetPrice + electricBill) * 1.2;
            }

            var waterTotal = months * waterPrice;
            var internetTotal = months * internetPrice;

            var average = (electricTotal + waterTotal + internetTotal + otherTotal) / months;

            Console.WriteLine("Electricity: {0:f2} lv", electricTotal);
            Console.WriteLine("Water: {0:f2} lv", waterTotal);
            Console.WriteLine("Internet: {0:f2} lv", internetTotal);
            Console.WriteLine("Other: {0:f2} lv", otherTotal);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}

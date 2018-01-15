using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLilly
{
    class CleverLilly
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var machinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var money = 0;
            var bonus = 10;
            var toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += bonus - 1;
                    bonus += 10;
                }
                else
                {
                    toys++;
                }
            }

            var totalMoney = money + toys * toyPrice;
            if (totalMoney >= machinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - machinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", machinePrice - totalMoney);
            }
        }
    }
}

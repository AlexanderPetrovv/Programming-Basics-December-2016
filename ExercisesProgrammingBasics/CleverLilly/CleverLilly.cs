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
            var washingMachine = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var toys = 0;
            var money = 0;
            var bonusMoney = 10;

            for (int bDay = 1; bDay <= age; bDay++)
            {
                if (bDay % 2 == 1)
                {
                    toys++;
                }
                else
                {
                    money += bonusMoney - 1;               // bonus for even years increase with 10 each time and brother takes 1
                    bonusMoney += 10;
                }
            }

            var totalMoney = toys * toyPrice + money;
            if (totalMoney >= washingMachine)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - washingMachine);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachine - totalMoney);
            }
        }
    }
}

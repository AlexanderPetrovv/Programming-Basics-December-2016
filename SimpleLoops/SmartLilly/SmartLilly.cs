using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMachPrice = double.Parse(Console.ReadLine());
            var toyPrice = double.Parse(Console.ReadLine());

            var money = 0.0;
            var toyMoney = 0.0;
            var bonus = 10.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += bonus;
                    money -= 1;
                    bonus += 10;
                }
                else
                {
                    toyMoney += toyPrice;
                }
            }

            var moneyTotal = toyMoney + money;

            if (moneyTotal >= washingMachPrice)
            {
                Console.WriteLine("Yes! {0:f2}", moneyTotal - washingMachPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachPrice - moneyTotal);
            }
        }
    }
}

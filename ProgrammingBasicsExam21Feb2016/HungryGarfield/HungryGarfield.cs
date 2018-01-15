using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            var moneyAvailable = decimal.Parse(Console.ReadLine());
            var dollarLvRate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine()) / dollarLvRate;
            var lasagnaPrice = decimal.Parse(Console.ReadLine()) / dollarLvRate;
            var sandwichPrice = decimal.Parse(Console.ReadLine()) / dollarLvRate;
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            var totalExpenses = pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + sandwichPrice * sandwichQuantity;

            if (totalExpenses <= moneyAvailable)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyAvailable - totalExpenses);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", totalExpenses - moneyAvailable);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var priceSquareM = double.Parse(Console.ReadLine());
            var bathroomArea = 0.5 * smallestRoomArea;
            var secondRoomArea = 1.1 * smallestRoomArea;
            var thridRoomArea = 1.1 * secondRoomArea;

            var totalArea = (smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thridRoomArea) * 1.05;
            var totalPrice = totalArea * priceSquareM;
            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}

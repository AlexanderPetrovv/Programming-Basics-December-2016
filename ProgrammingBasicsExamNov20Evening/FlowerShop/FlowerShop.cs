using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var magnolias = int.Parse(Console.ReadLine());
            var hyacinths = int.Parse(Console.ReadLine());      // zumbuli
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliaPrice = 3.25;
            var hyacinthPrice = 4.0;
            var rosePrice = 3.5;
            var cactusPrice = 8.0;

            var totalPrice = magnoliaPrice * magnolias + hyacinthPrice * hyacinths + rosePrice * roses + cactusPrice * cactuses;
            var afterTaxes = totalPrice * 0.95;

            if (afterTaxes >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(afterTaxes - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - afterTaxes));
            }
        }
    }
}

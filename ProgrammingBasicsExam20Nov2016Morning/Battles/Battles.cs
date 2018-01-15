using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            var pokemons1 = int.Parse(Console.ReadLine());
            var pokemons2 = int.Parse(Console.ReadLine());
            var fightsMax = int.Parse(Console.ReadLine());
            var count = 0;
            for (int p1 = 1; p1 <= pokemons1; p1++)
            {
                for (int p2 = 1; p2 <= pokemons2; p2++)
                {
                    if (count == fightsMax)
                    {
                        break;
                    }
                    count++;
                    Console.Write("({0} <-> {1}) ", p1, p2);
                }
            }
            Console.WriteLine();
        }
    }
}

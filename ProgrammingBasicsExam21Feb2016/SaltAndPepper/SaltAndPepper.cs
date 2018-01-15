using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltAndPepper
{
    class SaltAndPepper
    {
        static void Main(string[] args)
        {
            var dishes = ulong.Parse(Console.ReadLine());
            var command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandElements = command.Split(' ');
                string action = commandElements[0];
                int step = int.Parse(commandElements[1]);

                if (action == "salt")
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((dishes >> i) & 1) == 1)
                        {
                            ulong mask = ~((ulong)1 << i);
                            dishes = dishes & mask;
                        }
                    }
                }
                else
                {
                    for (var i = 0; i <= 63; i += step)
                    {
                        if (((dishes >> i) & 1) == 0)
                        {
                            ulong mask = (ulong)1 << i;
                            dishes = dishes | mask;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(dishes);
        }
    }
}

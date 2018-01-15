using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            var moneyAvailable = decimal.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var purchases = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                string actions = command;
                for (int i = 0; i < actions.Length; i++)
                {
                    decimal price = 0;
                    if (actions[i] >= 65 && actions[i] <= 90)              // uppercase letter check
                    {
                        price = actions[i] * 0.5m;
                        if (moneyAvailable < price)
                        {
                            continue;
                        }

                        moneyAvailable -= price;
                        purchases++;
                    }
                    else if (actions[i] >= 97 && actions[i] <= 122)         // lowercase letter check
                    {
                        price = actions[i] * 0.3m;
                        if (moneyAvailable < price)
                        {
                            continue;
                        }

                        moneyAvailable -= price;
                        purchases++;
                    }
                    else if (actions[i] == '%')
                    {
                        if (moneyAvailable > 0)
                        {
                            moneyAvailable /= 2;
                            purchases++;
                        }
                    }
                    else if (actions[i] == '*')
                    {
                        moneyAvailable += 10;
                    }
                    else
                    {
                        price = actions[i];
                        if (moneyAvailable < price)
                        {
                            continue;
                        }

                        moneyAvailable -= price;
                        purchases++;
                    }
                }

                command = Console.ReadLine();
            }

            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", moneyAvailable);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, moneyAvailable);
            }
        }
    }
}

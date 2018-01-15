using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsWithWords
{
    class NumsWithWords
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var name = "";

            if (number > 100 || number < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                if (number > 19 && number < 100)
                {
                    int tenths = number / 10;
                    int units = number % 10;

                    switch (tenths)
                    {
                        case 2: name += "twenty "; break;
                        case 3: name += "thirty "; break;
                        case 4: name += "fourty "; break;
                        case 5: name += "fifty "; break;
                        case 6: name += "sixty "; break;
                        case 7: name += "seventy "; break;
                        case 8: name += "eighty "; break;
                        case 9: name += "ninety "; break;
                    }
                    switch (units)
                    {
                        case 1: name += "one"; break;
                        case 2: name += "two"; break;
                        case 3: name += "three"; break;
                        case 4: name += "four"; break;
                        case 5: name += "five"; break;
                        case 6: name += "six"; break;
                        case 7: name += "seven"; break;
                        case 8: name += "eight"; break;
                        case 9: name += "nine"; break;
                    }
                    Console.WriteLine(name.Trim());
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    switch (number)
                    {
                        case 0: name += "zero"; break;
                        case 1: name += "one"; break;
                        case 2: name += "two"; break;
                        case 3: name += "three"; break;
                        case 4: name += "four"; break;
                        case 5: name += "five"; break;
                        case 6: name += "six"; break;
                        case 7: name += "seven"; break;
                        case 8: name += "eight"; break;
                        case 9: name += "nine"; break;
                        case 10: name += "ten"; break;
                        case 11: name += "eleven"; break;
                        case 12: name += "twelve"; break;
                        case 13: name += "thirteen"; break;
                        case 14: name += "fourteen"; break;
                        case 15: name += "fifteen"; break;
                        case 16: name += "sixteen"; break;
                        case 17: name += "seventeen"; break;
                        case 18: name += "eighteen"; break;
                        case 19: name += "nineteen"; break;
                    }
                    Console.WriteLine(name.Trim());
                }
            }
        }
    }
}

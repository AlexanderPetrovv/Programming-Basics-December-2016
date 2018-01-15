using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombination
{
    class LettersCombination
    {
        static void Main(string[] args)
        {
            var initialLetter = char.Parse(Console.ReadLine());
            var endLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());

            var count = 0;

            for (char letter1 = initialLetter; letter1 <= endLetter; letter1++)
            {
                for (char letter2 = initialLetter; letter2 <= endLetter; letter2++)
                {
                    for (char letter3 = initialLetter; letter3 <= endLetter; letter3++)
                    {
                        if (letter1 == skipLetter || letter2 == skipLetter || letter3 == skipLetter)
                        {
                            continue;
                        }
                        count++;
                        Console.Write("{0}{1}{2} ", letter1, letter2, letter3);
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

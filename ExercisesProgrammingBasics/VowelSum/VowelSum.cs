using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelSum
{
    class VowelSum
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var vowelSum = 0;

            for (int letter = 0; letter < text.Length; letter++)
            {
                var nextLetter = text[letter];
                switch (nextLetter)
                {
                    case 'a': vowelSum += 1; break;
                    case 'e': vowelSum += 2; break;
                    case 'i': vowelSum += 3; break;
                    case 'o': vowelSum += 4; break;
                    case 'u': vowelSum += 5; break;
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}

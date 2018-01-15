using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var vowelSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    vowelSum += 1;
                }
                else if (word[i] == 'e')
                {
                    vowelSum += 2;
                }
                else if (word[i] == 'i')
                {
                    vowelSum += 3;
                }
                else if (word[i] == 'o')
                {
                    vowelSum += 4;
                }
                else if (word[i] == 'u')
                {
                    vowelSum += 5;
                }
            }
            Console.WriteLine("The sum of all the vowels is: " + vowelSum);
        }
    }
}

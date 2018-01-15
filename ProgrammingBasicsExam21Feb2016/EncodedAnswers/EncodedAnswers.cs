using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            var numberOfQuestions = byte.Parse(Console.ReadLine());
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            string result = null;

            for (int q = 0; q < numberOfQuestions; q++)
            {
                var question = uint.Parse(Console.ReadLine());
                var answer = "";
                if (question % 4 == 0)
                {
                    a++;
                    answer = "a";
                }
                else if (question % 4 == 1)
                {
                    b++;
                    answer = "b";
                }
                else if (question % 4 == 2)
                {
                    c++;
                    answer = "c";
                }
                else if (question % 4 == 3)
                {
                    d++;
                    answer = "d";
                }

                result += answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}", a);
            Console.WriteLine("Answer B: {0}", b);
            Console.WriteLine("Answer C: {0}", c);
            Console.WriteLine("Answer D: {0}", d);
        }
    }
}

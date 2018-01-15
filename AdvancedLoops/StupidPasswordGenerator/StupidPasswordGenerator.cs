using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (var firstSymbol = 1; firstSymbol <= n; firstSymbol++)
            {
                for (var secondSymbol = 1; secondSymbol <= n; secondSymbol++)
                {
                    for (var thirdSymbol = 'a'; thirdSymbol < 'a' + l; thirdSymbol++)
                    {
                        for (var fourthSymbol = 'a'; fourthSymbol < 'a' + l; fourthSymbol++)
                        {
                            for (var fifthSymbol = Math.Max(firstSymbol, secondSymbol) + 1; fifthSymbol <= n; fifthSymbol++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstSymbol, secondSymbol, thirdSymbol, fourthSymbol, fifthSymbol);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

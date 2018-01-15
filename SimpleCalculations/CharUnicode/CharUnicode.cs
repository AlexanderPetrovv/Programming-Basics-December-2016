using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharUnicode
{
    class CharUnicode
    {
        static void Main(string[] args)
        {
            char symbol = '\u0048';
            Console.WriteLine(symbol);

            Console.WriteLine((char)0x48);
        }
    }
}

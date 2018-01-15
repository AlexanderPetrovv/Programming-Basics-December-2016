using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypeDeclaration
{
    class StringTypeDeclaration
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object result = string1 + " " + string2;
            Console.WriteLine(result);
            string string3 = result.ToString();  //string string3 = (string)result; 

            Console.WriteLine("The \"use\" of quatations causes difficulties.");
            Console.WriteLine(@"The ""use"" of quatations causes difficulties.");
        }
    }
}

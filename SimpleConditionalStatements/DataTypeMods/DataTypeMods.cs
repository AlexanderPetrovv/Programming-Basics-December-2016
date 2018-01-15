using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeMods
{
    class DataTypeMods
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable:\n0.Int\n1.Double\n2.String\nChoice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0: int variableInt = int.Parse(Console.ReadLine());
                        Console.WriteLine(variableInt + 1); break;
                case 1: double variableDouble = double.Parse(Console.ReadLine());
                        Console.WriteLine(variableDouble + 1); break;
                case 2: string variableString = Console.ReadLine();
                        Console.WriteLine(variableString + '*'); break;
            }
        }
    }
}

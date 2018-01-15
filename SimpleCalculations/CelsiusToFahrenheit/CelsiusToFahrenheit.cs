using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Temperature (°C) = ");
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("Temperature (°F) = {0}", Math.Round(fahrenheit, 2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Entry distance: ");
            var distance = double.Parse(Console.ReadLine());
            Console.Write("Convert from (m, mm, cm, mi, in, km, ft, yd): ");
            var convertFrom = Console.ReadLine().ToLower();
            Console.Write("Convert to (m, mm, cm, mi, in, km, ft, yd): ");
            var convertTo = Console.ReadLine().ToLower();

            switch (convertFrom)
            {
                case "m": break;
                case "mm": distance = distance / 1000; break;
                case "cm": distance = distance / 100; break;
                case "mi": distance = distance / 0.000621371192; break;
                case "in": distance = distance / 39.3700787; break;
                case "km": distance = distance / 0.001; break;
                case "ft": distance = distance / 3.2808399; break;
                case "yd": distance = distance / 1.0936133; break;
                default: break;
            }

            switch (convertTo)
            {
                case "m": break;
                case "mm": distance = distance * 1000; break;
                case "cm": distance = distance * 100; break;
                case "mi": distance = distance * 0.000621371192; break;
                case "in": distance = distance * 39.3700787; break;
                case "km": distance = distance * 0.001; break;
                case "ft": distance = distance * 3.2808399; break;
                case "yd": distance = distance * 1.0936133; break;
                default: break;
            }
            Console.WriteLine(distance + " " + convertTo);
        }
    }
}

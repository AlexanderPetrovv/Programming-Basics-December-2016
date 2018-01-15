using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            var vertices = int.Parse(Console.ReadLine());
            var minRectArea = int.Parse(Console.ReadLine());
            var rectArea = 0;
            var printNo = true;

            for (int left = -vertices; left < vertices; left++)
            {
                for (int top = -vertices; top < vertices; top++)
                {
                    for (int right = vertices; right > left; right--)
                    {
                        for (int bot = vertices; bot > top; bot--)
                        {
                            rectArea = (right - left) * (bot - top);

                            if (rectArea >= minRectArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bot, rectArea);
                                printNo = false;
                            }
                        }
                    }
                }
            }

            if (printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}

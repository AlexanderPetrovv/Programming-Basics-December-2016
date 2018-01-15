using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSignVar2
{
    class StopSignVar2
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1000;
            var n = int.Parse(Console.ReadLine());

            var dots = n + 1;
            var underscopes = 2 * n + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underscopes));
            underscopes -= 2;

            for (int rowUp = 0; rowUp < n; rowUp++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', --dots), new string('_', underscopes));
                underscopes += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (underscopes - 5) / 2));

            for (int rowDown = 0; rowDown < n; rowDown++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', rowDown), new string('_', underscopes));
                underscopes -= 2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            var lectures = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var jelevCnt = 0;
            var royalCnt = 0;
            var roliCnt = 0;
            var trofonCnt = 0;
            var sinoCnt = 0;
            var otherCnt = 0;

            for (int lect = 1; lect <= lectures; lect++)
            {
                var trainer = Console.ReadLine();
                switch (trainer)
                {
                    case "Jelev":
                        jelevCnt++;
                        break;
                    case "RoYaL":
                        royalCnt++;
                        break;
                    case "Roli":
                        roliCnt++;
                        break;
                    case "Trofon":
                        trofonCnt++;
                        break;
                    case "Sino":
                        sinoCnt++;
                        break;
                    default:
                        otherCnt++;
                        break;
                }
            }

                var moneyPerLecture = budget / lectures;

                var jelevMoney = moneyPerLecture * jelevCnt;
                var royalMoney = moneyPerLecture * royalCnt;
                var roliMoney = moneyPerLecture * roliCnt;
                var trofonMoney = moneyPerLecture * trofonCnt;
                var sinoMoney = moneyPerLecture * sinoCnt;
                var otherMoney = moneyPerLecture * otherCnt;

                Console.WriteLine("Jelev salary: {0:f2} lv", jelevMoney);
                Console.WriteLine("RoYaL salary: {0:f2} lv", royalMoney);
                Console.WriteLine("Roli salary: {0:f2} lv", roliMoney);
                Console.WriteLine("Trofon salary: {0:f2} lv", trofonMoney);
                Console.WriteLine("Sino salary: {0:f2} lv", sinoMoney);
                Console.WriteLine("Others salary: {0:f2} lv", otherMoney);
        }
    }
}

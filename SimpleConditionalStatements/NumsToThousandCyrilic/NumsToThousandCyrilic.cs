using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsToThousandCyrilic
{
    class NumsToThousandCyrilic
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());   
            var hundreds = number / 100;
            var tenths = (number / 10) % 10;
            var units = number % 10;
            var name = "";

            if (number >=0 && number <= 1000)
            {
                    switch (hundreds)
                    {
                        case 1: name += "Сто "; break;
                        case 2: name += "Двеста"; break;
                        case 3: name += "Триста"; break;
                        case 4: name += "Четиристотин"; break;
                        case 5: name += "Петстотин"; break;
                        case 6: name += "Шестстотин"; break;
                        case 7: name += "Седемстотин"; break;
                        case 8: name += "Осемстотин"; break;
                        case 9: name += "Деветстотин"; break;
                    }
                    switch (tenths)
                    {
                        case 2: name += "двадесет"; break;
                        case 3: name += "тридесет"; break;
                        case 4: name += "четиридесет"; break;
                        case 5: name += "петдесет"; break;
                        case 6: name += "шестдесет"; break;
                        case 7: name += "седемдесет"; break;
                        case 8: name += "осемдесет"; break;
                        case 9: name += "деветдесет"; break;
                    }
                    switch (units)
                    {
                        case 1: name += "едно"; break;
                        case 2: name += "две"; break;
                        case 3: name += "три"; break;
                        case 4: name += "четири"; break;
                        case 5: name += "пет"; break;
                        case 6: name += "шест"; break;
                        case 7: name += "седем"; break;
                        case 8: name += "осем"; break;
                        case 9: name += "девет"; break;
                    }
                if (tenths != 0 && units == 0)
                {
                    Console.WriteLine(" и " + name.Trim());
                }
                else if (tenths != 0 && units != 0)
                {
                    Console.WriteLine(" и " + name.Trim());
                }
                if (number < 20)
                {
                    switch (number)
                    {
                        case 1: name += "Едно"; break;
                        case 2: name += "Две"; break;
                        case 3: name += "Три"; break;
                        case 4: name += "Четири"; break;
                        case 5: name += "Пет"; break;
                        case 6: name += "Шест"; break;
                        case 7: name += "Седем"; break;
                        case 8: name += "Осем"; break;
                        case 9: name += "Девет"; break;
                        case 10: name += "Десет"; break;
                        case 11: name += "Единадесет"; break;
                        case 12: name += "Дванадесет"; break;
                        case 13: name += "Тринадесет"; break;
                        case 14: name += "Четиринадесет"; break;
                        case 15: name += "Петнадесет"; break;
                        case 16: name += "Шестнадесет"; break;
                        case 17: name += "Седемнадесет"; break;
                        case 18: name += "Осемнадесет"; break;
                        case 19: name += "Деветнадесет"; break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Грешка!");
            }
        }
    }
}

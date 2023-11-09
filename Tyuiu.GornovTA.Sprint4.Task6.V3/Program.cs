using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №3                                                              *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь", };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < month.Length - 1; i++)
            {
                Console.WriteLine(month[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Кол-во элементов длина которых < 6:");
            int nums = ds.Calculate(month);
            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}

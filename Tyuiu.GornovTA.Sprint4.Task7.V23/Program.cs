using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint4.Task7.V23.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "678135972584";
            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №23                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Кол-во чётных значений = " + res);
            Console.ReadKey();
        }
    }
}

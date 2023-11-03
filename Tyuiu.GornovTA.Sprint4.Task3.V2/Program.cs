using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint4.Task3.V2.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayValue = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                          { 4, 6, 5, 5, 7 },
                                          { 3, 8, 8, 3, 5 },
                                          { 5, 7, 5, 4, 4 },
                                          { 8, 8, 3, 7, 6 } };
            int rows = arrayValue.GetUpperBound(0) + 1;
            int columns = arrayValue.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №2                                                              *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arrayValue[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(arrayValue);
            Console.WriteLine("Максимальный эелемент первой строки = " + res);
            Console.ReadKey();
        }
    }
}

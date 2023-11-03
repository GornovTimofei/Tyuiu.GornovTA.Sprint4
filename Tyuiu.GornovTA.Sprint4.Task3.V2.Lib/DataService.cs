using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GornovTA.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[0, i] > maxElement)
                {
                    maxElement = array[0, i];
                }
            }
            return maxElement;
        }
    }
}

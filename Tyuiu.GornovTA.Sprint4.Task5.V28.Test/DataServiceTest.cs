using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint4.Task5.V28.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -5, 1, 2, 3, -1 }, 
                { 1, 2, 1, 2, 1 }, 
                { 2, 2, 3, -4, -2 }, 
                { -1, -1, 5, 2, -6 }, 
                { 1, -1, -3, 3, 2 }, };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { 0, 1, 2, 3, 0 }, 
                { 1, 2, 1, 2, 1 }, 
                { 2, 2, 3, 0, 0 }, 
                { 0, 0, 5, 2, 0 }, 
                { 1, 0, 0, 3, 2 }, };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

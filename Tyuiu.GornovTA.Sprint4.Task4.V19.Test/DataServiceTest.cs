using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint4.Task4.V19.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 6, 7, 3, 5, 1 },
                { 6, 5, 2, 2, 7 },
                { 2, 6, 4, 6, 6 },
                { 7, 5, 5, 2, 6 },
                { 3, 1, 5, 7, 7 } };
            int res = ds.Calculate(mas2);
            int wait = 68;
            Assert.AreEqual(wait, res);
        }
    }
}

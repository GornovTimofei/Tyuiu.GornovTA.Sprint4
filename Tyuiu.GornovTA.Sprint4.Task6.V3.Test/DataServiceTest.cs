using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.GornovTA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь", };
            int res = ds.Calculate(month);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}

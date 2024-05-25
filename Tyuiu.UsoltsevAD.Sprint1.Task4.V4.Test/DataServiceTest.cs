using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint1.Task4.V4.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3, y = 1, wait = 0.8;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}

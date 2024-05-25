using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint1.Task1.V18.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 4.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint1.Task7.V13.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            double wait = 1.261;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

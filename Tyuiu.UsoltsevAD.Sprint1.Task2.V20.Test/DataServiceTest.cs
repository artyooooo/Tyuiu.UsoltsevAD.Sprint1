using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint1.Task2.V20.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSquaresSumm()
        {
            DataService ds = new DataService();
            int value = 3;
            int valueTwo = 4;
            var res = ds.CalculateSquaresSumm(value, valueTwo);
            Assert.AreEqual(25, res);
        }
    }
}

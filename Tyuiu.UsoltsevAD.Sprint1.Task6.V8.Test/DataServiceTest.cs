using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint1.Task6.V8.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLetterToEnd()
        {
            DataService ds = new DataService();
            string text = "привет";
            string res = ds.MoveLetterToEnd(text);
            string wait = "риветп";
            Assert.AreEqual(wait, res);
        }
    }
}

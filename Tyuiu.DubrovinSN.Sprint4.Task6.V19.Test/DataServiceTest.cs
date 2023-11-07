using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint4.Task6.V19.Lib;

namespace Tyuiu.DubrovinSN.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            string[] mas = {"Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave"};
            int res = ds.Calculate(mas);
            Assert.AreEqual(4, res);
        }
    }
}

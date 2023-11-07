using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint4.Task7.V1.Lib;

namespace Tyuiu.DubrovinSN.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 3;
            int[,] mas = new int[rows, columns];
            string str = "135792468";
            int res = ds.Calculate(rows,columns,str);
            Assert.AreEqual(4, res);
        }
    }
}

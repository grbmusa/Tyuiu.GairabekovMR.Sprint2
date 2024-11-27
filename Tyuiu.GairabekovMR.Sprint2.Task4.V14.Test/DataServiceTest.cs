using Tyuiu.GairabekovMR.Sprint2.Task4.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.GairabekovMR.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double expected = Math.Round(Math.Pow(y, 2 - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12), 3);
            double actual = ds.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double expected = Math.Round(Math.Pow(2 + 1 / Math.Pow(x, 2), y), 3);
            double actual = ds.Calculate(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}



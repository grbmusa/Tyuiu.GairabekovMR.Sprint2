using Tyuiu.GairabekovMR.Sprint2.Task5.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.GairabekovMR.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual("Пятница", dataService.FindDayName(20, 7));
        }
    }
}
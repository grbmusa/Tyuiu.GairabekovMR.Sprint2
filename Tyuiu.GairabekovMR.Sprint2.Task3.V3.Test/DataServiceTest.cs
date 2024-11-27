using Tyuiu.GairabekovMR.Sprint2.Task3.V3.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 486;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = 0.951;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -34;
            double wait = -373.971;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}



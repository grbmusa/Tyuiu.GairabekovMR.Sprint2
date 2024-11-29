using Tyuiu.GairabekovMR.Sprint2.Task4.V14.Lib;
namespace Tyuiu.GairabekovMR.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 16;
            double res = ds.Calculate(x, y);
            double wait = 89966.884;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 0.091;
            Assert.AreEqual(wait, res);
        }
    }
}


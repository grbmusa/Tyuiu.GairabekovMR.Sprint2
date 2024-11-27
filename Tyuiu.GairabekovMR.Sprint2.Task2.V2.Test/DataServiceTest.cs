using Tyuiu.GairabekovMR.Sprint2.Task2.V2.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test_Dotintinarea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 3;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Test_Dotnotinarea()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 2;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

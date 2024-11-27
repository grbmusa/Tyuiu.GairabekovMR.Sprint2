using Tyuiu.GairabekovMR.Sprint2.Task1.V19.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;

            bool[] result = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
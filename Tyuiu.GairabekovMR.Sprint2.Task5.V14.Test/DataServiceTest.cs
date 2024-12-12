using Tyuiu.GairabekovMR.Sprint2.Task5.V14.Lib;
namespace Tyuiu.GairabekovMR.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 10;
            int d = 5;
            string res = ds.FindDayName(k, d);
            string wait = "�����������";
            Assert.AreEqual(wait, res);
        }
    }
}
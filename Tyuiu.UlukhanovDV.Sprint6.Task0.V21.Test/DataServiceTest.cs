using Tyuiu.UlukhanovDV.Sprint6.Task0.V21.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 13.0;
            Assert.AreEqual(res, wait);
        }
    }
}

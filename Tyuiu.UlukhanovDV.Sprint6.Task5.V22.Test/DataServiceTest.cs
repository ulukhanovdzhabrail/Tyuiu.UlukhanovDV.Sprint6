using System.IO;
using Tyuiu.UlukhanovDV.Sprint6.Task5.V22.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string testFile = "InPutDataFileTask5V22.txt";
            double[] expectedNumbers = {
                12,
                12.89,
                35,
                13.83,
                12.76,
                8.86
            };
            double[] actualNumbers = ds.LoadFromDataFile(testFile);

            Assert.AreEqual(expectedNumbers.Length, actualNumbers.Length);
        }
    }
}

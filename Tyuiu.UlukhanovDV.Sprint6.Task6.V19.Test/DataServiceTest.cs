using Tyuiu.UlukhanovDV.Sprint6.Task6.V19.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\djabr\Downloads\InPutDataFileTask6V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]                    
        public void TestMethod1()
        {
            string path = @"C:\Users\djabr\Downloads\InPutDataFileTask6V19.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                DataService ds = new DataService();
                string res = ds.CollectTextFromFile(path);
                string wait = ("HqrXl PAlR TwlB AWkgYPxilmC");
                Assert.AreEqual(wait, res);
            }
                
        }
    }
}

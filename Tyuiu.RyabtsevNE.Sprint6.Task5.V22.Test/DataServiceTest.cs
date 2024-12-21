using Tyuiu.RyabtsevNE.Sprint6.Task5.V22.Lib;

namespace Tyuiu.RyabtsevNE.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}

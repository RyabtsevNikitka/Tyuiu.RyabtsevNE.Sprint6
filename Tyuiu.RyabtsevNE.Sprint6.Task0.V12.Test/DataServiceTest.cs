using Tyuiu.RyabtsevNE.Sprint6.Task0.V12.Lib;

namespace Tyuiu.RyabtsevNE.Sprint6.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            double wail = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(wail, res);
        }
    }
}

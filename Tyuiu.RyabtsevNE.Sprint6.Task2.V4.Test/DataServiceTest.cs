using Tyuiu.RyabtsevNE.Sprint6.Task2.V4.Lib;

namespace Tyuiu.RyabtsevNE.Sprint6.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 0; int b = 0;
            double[] res = ds.GetMassFunction(a, b);
            double wail;
            wail = 3.25;

            Assert.AreEqual(res[0], wail);

        }
    }
}

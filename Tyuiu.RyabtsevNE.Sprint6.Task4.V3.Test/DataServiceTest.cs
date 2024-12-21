using Tyuiu.RyabtsevNE.Sprint6.Task4.V3.Lib;

namespace Tyuiu.RyabtsevNE.Sprint6.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -1, end = 1;
            double[] wait = new double[] { 2.93, 2.5, 0.71 };
            double[] res = new double[ds.GetMassFunction(start, end).Length];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

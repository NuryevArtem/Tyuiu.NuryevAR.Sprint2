using Tyuiu.NuryevAR.Sprint2.Task7.V10.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.1;
            double y = -1.2;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
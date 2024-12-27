using Tyuiu.NuryevAR.Sprint2.Task4.V25.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConditionTrue()
        {
            DataService ds = new DataService();
            double z = 1;
            var wait = 12;
            var res = ds.Calculate(z);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ConditionFalse()
        {
            DataService ds = new DataService();
            double y = 5;
            var wait = 24.5;
            var res = ds.Calculate(y);
            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.NuryevAR.Sprint2.Task5.V9.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual("???????", dataService.FindDateOfNextDay(5, 1));
        }
    }
}
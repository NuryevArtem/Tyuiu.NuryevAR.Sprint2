using Tyuiu.NuryevAR.Sprint2.Task1.V4.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 175, b = 176, c = 414, d = 414;
            bool[] res = new bool[6];
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
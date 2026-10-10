using Tyuiu.StryzhakMA.Sprint2.Task1.V30.Lib;

namespace Tyuiu.StryzhakMA.Sprint2.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, true, true, false };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}

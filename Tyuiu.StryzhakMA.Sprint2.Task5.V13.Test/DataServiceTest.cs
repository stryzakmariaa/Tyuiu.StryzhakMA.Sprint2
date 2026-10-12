using Tyuiu.StryzhakMA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.StryzhakMA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDate_NextDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 5;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "06.02.2024";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDate_EndOfMonth()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.02.2024";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDate_EndOfYear()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.01.2025";
            Assert.AreEqual(wait, res);
        }
    }
}

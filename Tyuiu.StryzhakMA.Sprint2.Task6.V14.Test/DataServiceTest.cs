using Tyuiu.StryzhakMA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.StryzhakMA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayOfWeek()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(365, 1));
        }
    }
}

using Tyuiu.GolovanovDO.Sprint2.Task7.V11.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.3;
            double y = 0.9;

            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

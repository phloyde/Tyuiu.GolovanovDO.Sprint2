using Tyuiu.GolovanovDO.Sprint2.Task2.V30.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 10;
            int y = 11;
            
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}

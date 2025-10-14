using Tyuiu.GolovanovDO.Sprint2.Task6.V9.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int m = 3;
            int n = 24;

            var res = ds.FindDateOfNextDay(m, n);
            string wait = ("25.03");

            Assert.AreEqual(wait, res);

        }
    }
}

using Tyuiu.GolovanovDO.Sprint2.Task4.V14.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 4;
            double res = ds.Calculate(x, y);


            Assert.AreEqual(25.629, res);
        }
    }
}

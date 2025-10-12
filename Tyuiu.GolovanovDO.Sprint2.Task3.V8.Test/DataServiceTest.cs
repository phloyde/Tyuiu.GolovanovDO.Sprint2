using Tyuiu.GolovanovDO.Sprint2.Task3.V8.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            DataService ds = new DataService();

            double res = ds.Calculate(x);
            Assert.AreEqual(-4.588, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = 0;
            DataService ds = new DataService();

            double res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double x = -1;
            DataService ds = new DataService();

            double res = ds.Calculate(x);
            Assert.AreEqual(0.25, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double x = -15;
            DataService ds = new DataService();

            double res = ds.Calculate(x);
            Assert.AreEqual(-164.667, res);
        }
    }
}

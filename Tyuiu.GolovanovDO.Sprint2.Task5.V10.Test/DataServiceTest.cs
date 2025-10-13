using Tyuiu.GolovanovDO.Sprint2.Task5.V10.Lib;
namespace Tyuiu.GolovanovDO.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2007;
            int m = 3;
            int n = 25;

            string res = ds.FindDateOfPreviousDay(g, m, n);
            
        }
    }
}

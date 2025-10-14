using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x * x + y * y <= 1) &&
                ((x <= 0) || (x >= 0 && y >= 0 && y >= x)))
            {
                res = true; 
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}

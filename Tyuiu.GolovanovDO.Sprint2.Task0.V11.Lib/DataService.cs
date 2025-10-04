using System.Data.SqlTypes;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // == != < > <= >=  x = 8105 y = 275

            bool[] res = new bool[6];
            res[0] = x == y + 7830; //true
            res[1] = x - 7830 != y; //false
            res[2] = x < y * 100;   //true
            res[3] = x * 0 > y;     //false
            res[4] = x - 10000 <= y;//true
            res[5] = x * 0 >= y;    //false

            return res;

        }
    }
}

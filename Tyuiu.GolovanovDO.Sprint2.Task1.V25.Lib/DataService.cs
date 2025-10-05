using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // == != < > <= >=
            // | & || && ! ^
            
            //int a = 247;
            //int b = 155;
            //int c = 325;
            //int d = 875;
            
            bool[] res = new bool[6];

            res[0] = c == (b * 2 + 15) | (a != c); //true
            res[1] = (c != (b * 2 + 15)) & (a == d); //false
            res[2] = (b < c) || (d > a);   //true
            res[3] = (a > d) && (a < d);     //false
            res[4] = !(res[3]) ;//true
            res[5] = (d >= a) ^ (b <= c); //false

            return res;
        }
    }
}

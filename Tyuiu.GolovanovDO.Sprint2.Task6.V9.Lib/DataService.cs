using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {

            if ((m == 1 && n == 31) ||
                    (m == 2 && n == 28) ||
                    (m == 3 && n == 31) ||
                    (m == 4 && n == 30) ||
                    (m == 5 && n == 31) ||
                    (m == 6 && n == 30) ||
                    (m == 7 && n == 31) ||
                    (m == 8 && n == 31) ||
                    (m == 9 && n == 30) ||
                    (m == 10 && n == 31) ||
                    (m == 11 && n == 30))
            {
                m = m + 1;
                n = 1;
            }
            else if (m == 12 && n == 31)
            {
                m = 1;
                n = 1;
            }
            else
            {
                n = n + 1;
            }

            if (m < 10 || n < 10)
            {
                if (m < 10 && n > 9)
                {
                    string res = ($"{n}.0{m}");
                    return res;
                }
                else if (m > 9 && n < 10)
                {
                    string res = ($"0{n}.{m}");
                    return res;
                }
                else if (m < 10 && n < 10)
                {
                    string res = ($"0{n}.0{m}");
                    return res;
                }
                else
                {
                    // Этот случай теоретически невозможен, но компилятор требует return
                    string res = ($"{n}.{m}");
                    return res;
                }
            }
            else
            {
                string res = ($"{n}.{m}");
                return res;
            }




        }

    }
}

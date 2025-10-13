using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
           

            if (n == 1)
            {
                if (m == 1)
                {
                    g = g - 1;
                    m = 12;
                }
                else
                {
                    m = m - 1;
                }


                if (m == 1)
                {
                    n = 31;
                }

                if (m == 2)
                {
                    n = 28;
                }

                if (m == 3)
                {
                    n = 31;
                }

                if (m == 4)
                {
                    n = 30;
                }

                if (m == 5)
                {
                    n = 31;
                }

                if (m == 6)
                {
                    n = 30;
                }

                if (m == 7)
                {
                    n = 31;
                }

                if (m == 8)
                {
                    n = 31;
                }

                if (m == 9)
                {
                    n = 30;
                }

                if (m == 10)
                {
                    n = 31;
                }

                if (m == 11)
                {
                    n = 30;
                }

                if (m == 12)
                {
                    n = 31;
                }
            }
            else
            {
                n = n - 1;
            }

            if (n < 10 && m < 10)
            {
                string res = ($"0{n}.0{m}.{g}");
                return res;
            }
            else
            {
                string res = ($"{n}.0{m}.{g}");
                return res;
            }

            if (n < 10)
            {
                string res = ($"0{n}.{m}.{g}");
                return res;
            }
            else
            {
                string res = ($"{n}.0{m}.{g}");
                return res;
            }

            if (m < 10)
            {
                string res = ($"{n}.0{m}.{g}");
                return res;
            }
            else
            {
                string res = ($"{n}.0{m}.{g}");
                return res;
            }






        }
    }
}

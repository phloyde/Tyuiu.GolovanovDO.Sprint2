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



                string month;
            switch (m)
            {
                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");

            }
            string res = ($"{n} {month} {g}");
            return res;

          

        }
    }
}

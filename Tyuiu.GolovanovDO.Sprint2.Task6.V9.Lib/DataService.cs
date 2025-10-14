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
           
                string month;
            switch (m)
            {
                case 1:
                    if (n < 10)
                    {
                        return ($"0{n} Январь");
                    }
                    else
                    {
                        return ($"{n} Январь");
                    }


                case 2:
                    if (n < 10)
                    {
                        return ($"0{n} Февраль");
                    }
                    else
                    {
                        return ($"{n} Февраль");
                    }
                case 3:
                    if (n < 10)
                    {
                        return ($"0{n} Март");
                    }
                    else
                    {
                        return ($"{n} Март");
                    }
                case 4:
                    if (n < 10)
                    {
                        return ($"0{n} Апрель");
                    }
                    else
                    {
                        return ($"{n} Апрель");
                    }
                case 5:
                    if (n < 10)
                    {
                        return ($"0{n} Май");
                    }
                    else
                    {
                        return ($"{n} Май");
                    }
                case 6:
                    if (n < 10)
                    {
                        return ($"0{n} Июнь");
                    }
                    else
                    {
                        return ($"{n} Июнь");
                    }
                case 7:
                    if (n < 10)
                    {
                        return ($"0{n} Июль");
                    }
                    else
                    {
                        return ($"{n} Июль");
                    }
                case 8:
                    if (n < 10)
                    {
                        return ($"0{n} Август");
                    }
                    else
                    {
                        return ($"{n} Август");
                    }
                case 9:
                    if (n < 10)
                    {
                        return ($"0{n} Сентябрь");
                    }
                    else
                    {
                        return ($"{n} Сентябрь");
                    }
                case 10:
                    if (n < 10)
                    {
                        return ($"0{n} Октябрь");
                    }
                    else
                    {
                        return ($"{n} Октябрь");
                    }
                case 11:
                    if (n < 10)
                    {
                        return ($"0{n} Ноябрь");
                    }
                    else
                    {
                        return ($"{n} Ноябрь");
                    }
                case 12:
                    if (n < 10)
                    {
                        return ($"0{n} Декабрь");
                    }
                    else
                    {
                        return ($"{n} Декабрь");
                    }
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            

            
        }

    }
}

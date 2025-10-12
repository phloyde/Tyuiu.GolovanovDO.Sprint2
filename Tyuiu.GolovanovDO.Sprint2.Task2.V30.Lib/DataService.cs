using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GolovanovDO.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((3 <= x && x <= 12) && (5 <= y && y <= 7)) ||
               (((3 <= x && x <= 5) || (9 <= x && x <= 12)) && (3 <= y && y <= 4))||
               (((x == 2) || (x == 13)) && ((4 <= y && y <= 6) || (6 <= y && y<= 7)))||
               ((x == 6)  && (8 <= y && y<= 10))||
               ((3 <= x && x <= 12) && (y == 11))||
               ((7 <= x && x <= 10) && (y == 12)))
            {
                return true;
            }
            else 
            { return false; }

        }
    }
}

using Tyuiu.GolovanovDO.Sprint2.Task2.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
   
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: операции сравнения                                                *");
        Console.WriteLine("* Задание #00                                                             *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
        Console.WriteLine("* в заштрихованной области.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int x;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());

        int y;
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
        {
            Console.WriteLine("Точка входит в закрашенную область");
        }
        else
        {
            Console.WriteLine("Точка не входит в закрашенную область");
        }
        Console.ReadKey();
    }
}
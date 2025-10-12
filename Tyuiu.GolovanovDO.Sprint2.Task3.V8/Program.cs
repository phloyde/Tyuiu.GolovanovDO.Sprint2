using Tyuiu.GolovanovDO.Sprint2.Task3.V8.Lib;
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

        Console.WriteLine("Введите значение Х:");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");
        Console.WriteLine("Значение функции = " +  res);
        Console.ReadKey();
    }
}
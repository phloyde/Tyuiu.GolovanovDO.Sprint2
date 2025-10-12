using Tyuiu.GolovanovDO.Sprint2.Task4.V14.Lib;
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
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использова-  *");
        Console.WriteLine("* нием тернарного оператора                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.WriteLine("Введите значение Х:");
        double x = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        var res = ds.Calculate(x, y);
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");

        Console.WriteLine(res);
    }
}
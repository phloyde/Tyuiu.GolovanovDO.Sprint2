using Tyuiu.GolovanovDO.Sprint2.Task0.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1| Выполнил: Голованов Д.О. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: операции сравнения                                                *");
        Console.WriteLine("* Задание #00                                                             *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил Голованов Данила Олегович | ПИНб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнения и арифметических выражений,    *");
        Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
        Console.WriteLine("* true, false, true, false, true, false, при х = 8105 и у = 275           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        int x = 8105;
        int y = 275; 
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");


        var res = ds.GetCompareOperations(x, y);
        Console.Write(res[0] + ", ");
        Console.Write(res[1] + ", ");
        Console.Write(res[2] + ", ");
        Console.Write(res[3] + ", ");
        Console.Write(res[4] + ", ");
        Console.Write(res[5] + ", ");
        Console.ReadKey();

    }
}
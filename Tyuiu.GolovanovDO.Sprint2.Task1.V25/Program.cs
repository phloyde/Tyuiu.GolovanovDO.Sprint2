using Tyuiu.GolovanovDO.Sprint2.Task1.V25.Lib;
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

        int a = 247;
        int b = 155;
        int c = 325;
        int d = 857 ;
        Console.WriteLine("a = 247");
        Console.WriteLine("b = 155");
        Console.WriteLine("c = 325");
        Console.WriteLine("d = 875");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             *");

        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);

        }
        Console.ReadLine();
    }
}
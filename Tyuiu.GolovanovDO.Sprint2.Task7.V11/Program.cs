using Tyuiu.GolovanovDO.Sprint2.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Введите значение Х:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
        {
            Console.WriteLine("Точка входит в область");
            
        }
        else
        {
            Console.WriteLine("Точка не входит в область");
        }
    }
}
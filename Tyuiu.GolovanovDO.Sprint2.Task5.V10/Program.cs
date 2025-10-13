using Tyuiu.GolovanovDO.Sprint2.Task5.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите день:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();

        Console.WriteLine("Предыдущий день это: " + ds.FindDateOfPreviousDay(g, m, n) + " Года");
        Console.ReadKey();
    }
}
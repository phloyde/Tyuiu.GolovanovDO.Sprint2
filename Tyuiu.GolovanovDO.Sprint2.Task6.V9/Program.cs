using Tyuiu.GolovanovDO.Sprint2.Task6.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите N:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите M:");
        int m = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();

        string res = ds.FindDateOfNextDay(m, n);

        Console.WriteLine("Результат :" + res); 
    }
}
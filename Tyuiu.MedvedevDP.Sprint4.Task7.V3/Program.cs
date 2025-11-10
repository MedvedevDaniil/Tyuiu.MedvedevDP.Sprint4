using Tyuiu.MedvedevDP.Sprint4.Task7.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string str = "27182818";
        int rows = 4;
        int cols = 2;

        Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Строка: {str}");
        Console.WriteLine($"Размер матрицы: {rows} x {cols}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("РЕЗУЛЬТАТ:");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(rows, cols, str);

        Console.WriteLine($"Количество нечётных чисел в матрице: {result}");

        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}
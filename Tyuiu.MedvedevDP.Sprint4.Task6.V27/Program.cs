using Tyuiu.MedvedevDP.Sprint4.Task6.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        string[] data = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

        Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
        Console.WriteLine("***************************************************************************");
        foreach (string item in data)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("РЕЗУЛЬТАТ:");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(data);

        Console.WriteLine($"Количество элементов, длина которых меньше 7: {result}");

        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}
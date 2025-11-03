using Tyuiu.MedvedevDP.Sprint4.Task3.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = {
            { 8, 7, 7, 8, 5 },
            { 4, 3, 5, 3, 6 },
            { 5, 3, 8, 6, 3 },
            { 6, 3, 8, 5, 4 },
            { 3, 6, 8, 3, 4 }
        };

        Console.WriteLine("Массив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(matrix);
        Console.WriteLine("Минимальный элемент в первом столбце массива: " + res);

        Console.ReadKey();
    }
}
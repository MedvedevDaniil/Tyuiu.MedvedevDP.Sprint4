using Tyuiu.MedvedevDP.Sprint4.Task5.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Random rnd = new Random();

        int rows = 5;
        int cols = 5;
        int[,] matrix = new int[rows, cols];

        Console.WriteLine("ИСХОДНЫЙ МАССИВ:");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rnd.Next(-4, 9); 
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("РЕЗУЛЬТАТ:");
        Console.WriteLine("***************************************************************************");

        int[,] resultMatrix = ds.Calculate(matrix);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{resultMatrix[i, j],3} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}
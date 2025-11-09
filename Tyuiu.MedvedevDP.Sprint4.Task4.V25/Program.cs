using Tyuiu.MedvedevDP.Sprint4.Task4.V25.Lib;

namespace Tyuiu.MedvedevDP.Sprint4.Task4.V25
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            DataService ds = new DataService();

            int rows = 5;
            int columns = 5;

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Введите элементы массива 5x5 (числа от 2 до 6):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите [{i},{j}] элемент: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("МАТРИЦА:");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);

            Console.WriteLine($"Сумма чётных элементов массива = {result}");

            Console.WriteLine();
        }
    }
}
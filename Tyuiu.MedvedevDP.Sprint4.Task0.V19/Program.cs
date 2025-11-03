using Tyuiu.MedvedevDP.Sprint4.Task0.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetMultOddArrEl(numsArray);
        Console.WriteLine("Произведение нечётных элементов массива: " + result);

        Console.ReadKey();
    }
}
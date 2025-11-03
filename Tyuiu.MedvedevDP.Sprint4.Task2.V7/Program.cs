using Tyuiu.MedvedevDP.Sprint4.Task2.V7.Lib;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len = 12; 

        int[] numsArray = new int[len];

        Console.Write("Массив (заполнен случайными числами от 4 до 9): ");
        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(4, 10);
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);
        Console.WriteLine("Сумма чётных элементов массива: " + res);

        Console.ReadKey();
    }
}
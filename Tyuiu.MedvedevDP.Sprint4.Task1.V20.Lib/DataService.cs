using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedvedevDP.Sprint4.Task1.V20.Lib
{
    public class DataService : ISprint4Task1V20
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
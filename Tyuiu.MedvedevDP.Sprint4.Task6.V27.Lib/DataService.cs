using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedvedevDP.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            string[] filtered = Array.FindAll(array, x => x.Length < 7);
            return filtered.Length;
        }
    }
}
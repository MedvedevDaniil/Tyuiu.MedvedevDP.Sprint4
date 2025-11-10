using Tyuiu.MedvedevDP.Sprint4.Task5.V23.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MedvedevDP.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { -1, 2, -3 }, { 4, -5, 6 }, { -7, 8, 0 } };

            int[,] expected = new int[,] { { 0, 2, 0 }, { 4, 0, 6 }, { 0, 8, 0 } };

            int[,] actual = ds.Calculate(matrix);

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
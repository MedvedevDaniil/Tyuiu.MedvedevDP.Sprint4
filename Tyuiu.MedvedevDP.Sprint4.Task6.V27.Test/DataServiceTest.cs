using Tyuiu.MedvedevDP.Sprint4.Task6.V27.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MedvedevDP.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = { "Квадрат", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            int expected = 1;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
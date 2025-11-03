using Tyuiu.MedvedevDP.Sprint4.Task1.V20.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MedvedevDP.Sprint4.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 0, 4, 7, 5, 3, 9, 2, 7, 0 };
            int res = ds.Calculate(numsArray);

            // Нечётные: 7, 5, 3, 9, 7 → сумма: 7+5+3+9+7 = 31
            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}
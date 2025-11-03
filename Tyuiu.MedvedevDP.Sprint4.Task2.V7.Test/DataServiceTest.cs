using Tyuiu.MedvedevDP.Sprint4.Task2.V7.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MedvedevDP.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 6, 7, 8, 9, 4, 6, 8, 5, 7, 9 };
            int res = ds.Calculate(numsArray);

            int wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}
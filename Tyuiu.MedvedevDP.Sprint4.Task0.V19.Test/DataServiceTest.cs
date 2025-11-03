using Tyuiu.MedvedevDP.Sprint4.Task0.V19.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MedvedevDP.Sprint4.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultOddArrEl(numsArray);

            int expected = 297675;

            Assert.AreEqual(expected, res);
        }
    }
}
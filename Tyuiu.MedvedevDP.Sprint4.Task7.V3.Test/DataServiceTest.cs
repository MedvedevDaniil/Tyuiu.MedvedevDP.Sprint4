using Tyuiu.MedvedevDP.Sprint4.Task7.V3.Lib;

namespace Tyuiu.MedvedevDP.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "27182818";
            int rows = 4;
            int cols = 2;

            int expected = 3;

            int actual = ds.Calculate(rows, cols, str);

            Assert.AreEqual(expected, actual);
        }
    }
}
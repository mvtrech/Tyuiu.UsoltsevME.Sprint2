
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task4.V6.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValue()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 1;

            double wait = 0.5;
            double result = ds.Calculate(x, y);

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}

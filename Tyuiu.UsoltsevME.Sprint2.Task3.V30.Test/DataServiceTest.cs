using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task3.V30.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual(2.0, ds.Calculate(0), 0.001);
            Assert.AreEqual(0.5, ds.Calculate(-1), 0.001);
            Assert.IsTrue(double.IsNaN(ds.Calculate(-34)));
        }
    }
}

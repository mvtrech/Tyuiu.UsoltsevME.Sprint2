
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task7.V4.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0.5));

            Assert.IsFalse(ds.CheckDotInShadedArea(0, -0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.1, 0.1));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));
        }
    }
}

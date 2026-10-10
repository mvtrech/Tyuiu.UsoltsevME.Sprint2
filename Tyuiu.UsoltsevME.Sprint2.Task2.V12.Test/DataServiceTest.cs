
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task2.V12.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckShadedArea()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 4));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 12));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15));
        }
    }
}

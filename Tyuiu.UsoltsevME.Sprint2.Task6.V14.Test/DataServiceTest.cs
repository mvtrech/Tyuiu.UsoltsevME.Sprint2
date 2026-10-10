
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task6.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayNameTest()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("среда", ds.FindDayName(3, 1));
        }
    }
}

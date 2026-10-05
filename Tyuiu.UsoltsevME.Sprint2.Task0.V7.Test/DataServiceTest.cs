using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task0.V7.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 103;
            int y = 475;

            bool[] wait = { true, false, true, true, true, false };

            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
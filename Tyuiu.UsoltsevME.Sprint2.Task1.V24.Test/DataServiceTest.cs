using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint2.Task1.V24.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;

            bool[] wait = { true, false, true, false, true, false };

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}

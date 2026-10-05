using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UsoltsevME.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == x;
            result[1] = x != x;
            result[2] = x < y;
            result[3] = y > x;
            result[4] = x <= y;
            result[5] = x >= y;

            return result;
        }
    }
}
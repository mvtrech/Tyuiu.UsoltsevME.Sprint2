using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UsoltsevME.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = a == b;
            result[1] = a != b;
            result[2] = a > c;
            result[3] = a < c;
            result[4] = a >= d;
            result[5] = a <= c;

            return result;
        }
    }
}

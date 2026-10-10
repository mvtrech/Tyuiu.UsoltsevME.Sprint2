
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UsoltsevME.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inBigCircle = x * x + y * y <= 1 && y >= 0;

            bool inSmallCircle = x >= 0 && y >= 0 &&
                                 x * x + y * y < 0.09;

            return inBigCircle && !inSmallCircle;
        }
    }
}

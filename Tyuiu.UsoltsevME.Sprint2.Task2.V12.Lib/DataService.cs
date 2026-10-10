
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UsoltsevME.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result = false;

            if (y == 3 && ((x >= 3 && x <= 5) ||
                           (x >= 9 && x <= 12)))
            {
                result = true;
            }

            if ((y == 4 || y == 5) && x >= 3 && x <= 12)
            {
                result = true;
            }

            if ((y == 6 || y == 7) && x >= 3 && x <= 13)
            {
                result = true;
            }

            if (y == 8 && x >= 6 && x <= 13)
            {
                result = true;
            }

            if ((y == 9 || y == 10) &&
                ((x >= 6 && x <= 7) || (x >= 11 && x <= 12)))
            {
                result = true;
            }

            if (y == 11 &&
                ((x >= 3 && x <= 7) || (x >= 11 && x <= 12)))
            {
                result = true;
            }

            if (y == 12 &&
                (x == 7 || (x >= 11 && x <= 12)))
            {
                result = true;
            }

            return result;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UsoltsevME.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3) /
                    (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) - 2);
            }
            else if (x > -34 && x < 2)
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -34)
            {
                y = x + 10 * x - 1 / x;
            }
            else
            {
                return double.NaN;
            }

            return Math.Round(y, 3);
        }
    }
}

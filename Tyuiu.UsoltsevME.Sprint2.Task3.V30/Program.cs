using Tyuiu.UsoltsevME.Sprint2.Task3.V30.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = ds.Calculate(x);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            if (double.IsNaN(y))
            {
                Console.WriteLine("Для данного X формула не задана.");
            }
            else
            {
                Console.WriteLine("X = " + x);
                Console.WriteLine("Y = " + y);
            }

            Console.ReadKey();
        }
    }
}


using Tyuiu.UsoltsevME.Sprint2.Task2.V12.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task2.V12
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
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Точка находится в закрашенной области: " + result);

            Console.ReadKey();
        }
    }
}

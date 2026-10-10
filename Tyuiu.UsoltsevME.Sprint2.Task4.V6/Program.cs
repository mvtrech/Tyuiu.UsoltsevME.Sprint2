using Tyuiu.UsoltsevME.Sprint2.Task4.V6.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("z = " + result);

            Console.ReadKey();
        }
    }
}

using Tyuiu.UsoltsevME.Sprint2.Task1.V24.Lib;

using Tyuiu.UsoltsevME.Sprint2.Task1.V24.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("(" + string.Join(", ", result) + ")");

            Console.ReadKey();
        }
    }
}

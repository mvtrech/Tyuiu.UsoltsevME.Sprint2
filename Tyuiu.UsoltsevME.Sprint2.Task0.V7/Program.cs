using Tyuiu.UsoltsevME.Sprint2.Task0.V7.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task0.V7
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
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("(" + result[0] + ", " + result[1] + ", " +
                result[2] + ", " + result[3] + ", " +
                result[4] + ", " + result[5] + ")");

            Console.ReadKey();
        }
    }
}
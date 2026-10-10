
using Tyuiu.UsoltsevME.Sprint2.Task6.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите номер дня года k (1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день недели 1 января d (1-7): ");
            int d = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDayName(k, d);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("День недели: " + result);

            Console.ReadKey();
        }
    }
}

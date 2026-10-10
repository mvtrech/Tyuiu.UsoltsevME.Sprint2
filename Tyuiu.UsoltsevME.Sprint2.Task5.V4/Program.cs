using Tyuiu.UsoltsevME.Sprint2.Task5.V4.Lib;

namespace Tyuiu.UsoltsevME.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите номер масти (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindCardSuit(m);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Масть: " + result);

            Console.ReadKey();
        }
    }
}

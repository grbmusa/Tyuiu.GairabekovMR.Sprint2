using Tyuiu.GairabekovMR.Sprint2.Task1.V19.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* можно чередовать, но использовать один раз в выражении) и логических    *");
            Console.WriteLine("* операций (|, &, ||, &&, !, ^, последовательность операций не должна     *");
            Console.WriteLine("* нарушаться), а также арифметических выражений, которая вернет           *");
            Console.WriteLine("* логическую последовательность(массив): (True, False, True, False,       *");
            Console.WriteLine("* True, False), при a = 696, b = 354, c = 423, d = 957                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* a = {a}                                                                 *");
            Console.WriteLine($"* b = {b}                                                                 *");
            Console.WriteLine($"* c = {c}                                                                 *");
            Console.WriteLine($"* d = {d}                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}

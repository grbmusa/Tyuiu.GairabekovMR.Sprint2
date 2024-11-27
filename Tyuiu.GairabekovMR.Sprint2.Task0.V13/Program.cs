using Tyuiu.GairabekovMR.Sprint2.Task0.V13.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1905;
            int y = 475;
            bool[] res = GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (False, True, False, True, False, True), при x = 1905, y = 475          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* x = {x}                                                                *");
            Console.WriteLine($"* y = {y}                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }

        static bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x == y,  // False
                x != y,  // True
                x < y,   // False
                x > y,   // True
                x <= y,  // False
                x >= y   // True
            };
        }
    }
}
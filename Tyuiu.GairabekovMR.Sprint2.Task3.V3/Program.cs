using Tyuiu.GairabekovMR.Sprint2.Task3.V3.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой;                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));
        }
    }
}

namespace Tyuiu.GairabekovMR.Sprint2.Task3.V3.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double y;

            if (x < 0)
            {
                if (x < -10)
                {
                    y = Math.Pow(x, 2) + 2 * x + 1;
                }
                else
                {
                    y = Math.Pow(x, 2) - 4 * x + 5;
                }
            }
            else
            {
                if (x < 10)
                {
                    y = Math.Sqrt(x) + Math.Log(x + 1);
                }
                else
                {
                    y = x - Math.Sin(x);
                }
            }

            return Math.Round(y, 3);
        }
    }
}

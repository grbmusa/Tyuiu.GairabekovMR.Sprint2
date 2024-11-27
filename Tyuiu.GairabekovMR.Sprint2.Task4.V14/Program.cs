using Tyuiu.GairabekovMR.Sprint2.Task4.V14.Lib;

namespace Tyuiu.GairabekovMR.Sprint2.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x, y с клавиатуры, если x * 3 < sqrt(y) + 20, то (2 + 1/x^2)^y*");
            Console.WriteLine("* иначе z = (y^(2 - (cos(x))^2 + 10)) / (x^2 - (sin(y))^2 + 12).           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}

namespace Tyuiu.GairabekovMR.Sprint2.Task4.V14.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double z = (x * 3 < Math.Sqrt(y) + 20)
                ? Math.Pow(2 + 1 / Math.Pow(x, 2), y)
                : (Math.Pow(y, 2 - Math.Cos(x) * Math.Cos(x) + 10) / (Math.Pow(x, 2) - Math.Sin(y) * Math.Sin(y) + 12));
            return Math.Round(z, 3);
        }
    }
}




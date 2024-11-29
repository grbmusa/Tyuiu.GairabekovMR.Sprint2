using Tyuiu.GairabekovMR.Sprint2.Task6.V9.Lib;
namespace Tyuiu.GairabekovMR.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Гайрабеков М.Р. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПБ-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Month, Day;
            Console.WriteLine("Введите номер месяца: ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите номер дня: ");
            Day = Convert.ToInt32(Console.ReadLine());

            if ((Month > 12 || Day>31) || (Month % 2 != 0 && Day == 31) || (Month == 2 && Day > 28))
            {
                Console.WriteLine("Такой даты не сушествует.");
            }
            else
            {
                Console.WriteLine(ds.FindDateOfNextDay(Month, Day));
            }
        }
    }
}

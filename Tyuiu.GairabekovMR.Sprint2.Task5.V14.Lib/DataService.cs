using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GairabekovMR.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {



            int dayOfWeek = (d + k - 2) % 7 + 1;
            
            string dayName = dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new InvalidOperationException()
            };


            return dayName;

        }
    }

}

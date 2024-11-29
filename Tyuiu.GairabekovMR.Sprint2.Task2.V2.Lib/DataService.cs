using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GairabekovMR.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public DataService()
        {
        }

        public bool CheckDotInShadedArea(int x, int y)
        {
            bool check = false;
            if ((y == 3 && (x >= 3 && x <= 5)) || (y == 3 && (x >= 9 && x <= 12))
                || (y == 4 && (x >= 3 && x <= 5)) || (y == 4 && (x >= 9 && x <= 12))
                || (y == 5 && (x >= 3 && x <= 12))
                || (y == 6 && (x >= 3 && x <= 13))
                || (y == 7 && (x >= 3 && x <= 13))
                || (y == 8 && (x >= 4 && x <= 13))
                || (y == 9 && (x >= 4 && x <= 5)) || (y == 9 && (x >= 10 && x <= 12))
                || (y == 10 && (x >= 4 && x <= 5)) || (y == 10 && (x >= 10 && x <= 12))
                || (y == 11 && (x >= 3 && x <= 5)) || (y == 11 && (x >= 10 && x <= 12))
                || (y == 12 && (x >= 4 && x <= 6)) || (y == 12 && x == 10)
                || (y == 13 && (x >= 4 && x <= 6)))
            {
                check = true;
            }
            return check;
        }
    }
}

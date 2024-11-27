using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GairabekovMR.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public DataService()
        {
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a > b) | (c < d);    // True
            result[1] = (a == b) & (c > d);   // False
            result[2] = (a != b) || (c == d); // True
            result[3] = (a < b) && (c >= d);  // False
            result[4] = !(a <= b);            // True
            result[5] = (a >= b) ^ (c <= d);  // False

            return result;
        }
    }
}

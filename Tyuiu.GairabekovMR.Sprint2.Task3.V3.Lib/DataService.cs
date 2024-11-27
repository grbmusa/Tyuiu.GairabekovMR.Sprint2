using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GairabekovMR.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public DataService()
        {
        }

        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x * Math.Pow((x + 1) / (x - 1), 5);
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 6) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 5);
            }
            else if (-33<x & x<2)
            {
                res = Math.Pow((1 + 1/Math.Pow(x,2)), x);
            }
            else if (x<-33)
            {
                res = x + 10 * x - (1 / x);
            }
            return Math.Round(res,3);


        }   
    }
}

﻿using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GairabekovMR.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;   // False
            res[1] = x != y;   // True
            res[2] = x < y;    // False
            res[3] = x > y;    // True
            res[4] = x <= y;   // False
            res[5] = x >= y;   // True
            return res;
        }
    }
}

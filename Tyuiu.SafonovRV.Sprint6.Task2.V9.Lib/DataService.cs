﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafonovRV.Sprint6.Task2.V9.Lib
{
    public class DataService : ISprint6Task2V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2,2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}

    


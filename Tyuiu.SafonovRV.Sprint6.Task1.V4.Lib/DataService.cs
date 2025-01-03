﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafonovRV.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
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
                y = Math.Round((Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2*x, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
        
    


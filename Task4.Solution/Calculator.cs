using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAverageInterface averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            return averagingMethod.AveragingMethod(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            return averagingMethod(values);
        }
    }
}
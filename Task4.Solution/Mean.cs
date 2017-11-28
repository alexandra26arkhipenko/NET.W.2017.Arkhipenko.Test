using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution
{
    public class Mean : IPredicate
    {
        public double AveragingMethod(List<double> values)
        {
            return values.Sum()/ values.Count;
        }
    }
}
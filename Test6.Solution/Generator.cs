using System.Collections.Generic;

namespace Test6.Solution
{
    public class Generator 
    {
        public static IEnumerable<T> Generate<T>(int count, T a, T b, ICalculate<T> calculate)
        {
            if (count == 0) yield break;
            if (count == 1) yield return a;
            if (count == 2) yield return b;

            for (int i = 0; i < count; i++)
            {
                var item = b;
                b = calculate.CalculateNumber(b, a);
                yield return b;
                a = item;
            }
        }
          
    }
}
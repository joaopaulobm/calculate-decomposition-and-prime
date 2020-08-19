using System;
using System.Collections.Generic;

namespace CalcDecomposition.Shared.Queries._Helpers
{
    internal class ListDividersNumbers
    {
        public static IEnumerable<int> ByNumber(int number)
        {
            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (number / i == i)
                        yield return i;
                    else
                    {
                        yield return i;
                        yield return number / i;
                    }
                }
            }
        }
    }
}

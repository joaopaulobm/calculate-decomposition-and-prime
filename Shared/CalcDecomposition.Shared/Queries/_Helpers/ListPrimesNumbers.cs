using System.Collections.Generic;
using System.Linq;

namespace CalcDecomposition.Shared.Queries._Helpers
{
    internal class ListPrimesNumbers
    {
        public static IEnumerable<int> ByListDividers(IEnumerable<int> dividers)
        {
            dividers = dividers.Where(value => value % 2 != 0 || value == 2);

            foreach (var number in dividers)
            {
                if (IsPrime(number))
                    yield return number;
            }
        }

        private static bool IsPrime(int number)
        {
            return Enumerable.Range(start: 1, count: number)
                             .Where(value => number % value == 0)
                             .SequenceEqual(second: new[] { 1, number });
        }
    }
}

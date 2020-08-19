using CalcLocaliza.Shared.Queries._Helpers;
using System.Linq;

namespace CalcLocaliza.Shared.Queries
{
    public static class CalculateDivisorQueries
    {
        public static CalculateDivisorResult GetDividersByNumber(int number)
        {
            if (!Validate(number))
                return new CalculateDivisorResult(false, Constants.NumeroInvalido);

            var dividers = ListDividersNumbers.ByNumber(number).OrderBy(number => number);
            var primes = ListPrimesNumbers.ByListDividers(dividers);

            var data = new
            {
                dividers,
                primes
            };

            return new CalculateDivisorResult(dividers, primes, true);
        }

        private static bool Validate(int number) => number > 0;
    }
}

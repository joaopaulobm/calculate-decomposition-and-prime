using CalcLocaliza.Shared.Commands.Contracts;
using System.Collections.Generic;

namespace CalcLocaliza.Shared.Queries
{
    public class CalculateDivisorResult : ResultController
    {
        public CalculateDivisorResult(
            bool success,
            string message = null)
        {
            Success = success;
            Message = message;
        }

        public CalculateDivisorResult(
            IEnumerable<int> dividers,
            IEnumerable<int> primes,
            bool success,
            string message = null)
        {
            Dividers = dividers;
            Primes = primes;
            Success = success;
            Message = message;
        }

        public IEnumerable<int> Dividers { get; set; }
        public IEnumerable<int> Primes { get; set; }

        public override string ToString()
        {
            var divisores = string.Join(" - ", Dividers);
            var primos = string.Join(" - ", Primes);

            return $"Divisores: {divisores} \n" +
                   $"Divisores Primos: {primos}\n";
        }
    }
}

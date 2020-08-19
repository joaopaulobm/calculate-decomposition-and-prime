using CalcLocaliza.Shared.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CalcLocaliza.Tests.QueryTests
{
    [TestClass]
    public class CalculateDivisorQueriesTests
    {
        private readonly IList<int> _dividersOf40;
        private readonly IList<int> _primesDividersOf40;

        public CalculateDivisorQueriesTests()
        {
            _dividersOf40 = new List<int> { 1, 2, 4, 5, 8, 10, 20, 40 };
            _primesDividersOf40 = new List<int> { 2, 5 };
        }

        [TestMethod]
        [DataRow(40)]
        public void Should_Return_All_Numbers_Dividers_Of_40(int number)
        {
            var resultQuery = CalculateDivisorQueries.GetDividersByNumber(number);
            var equals = Enumerable.SequenceEqual(first: resultQuery.Dividers, second: _dividersOf40);

            Assert.IsTrue(equals);
        }

        [TestMethod]
        [DataRow(40)]
        public void Should_Return_All_Prime_Numers_Divisors_Of_40(int number)
        {
            var resultQuery = CalculateDivisorQueries.GetDividersByNumber(number);
            var equals = Enumerable.SequenceEqual(first: resultQuery.Primes, second: _primesDividersOf40);

            Assert.IsTrue(equals);
        }

        [TestMethod]
        [DataRow(60)]
        [DataRow(90)]
        [DataRow(120)]
        public void Should_Return_Three_Primes_Numbers(int number)
        {
            var resultQuery = CalculateDivisorQueries.GetDividersByNumber(number);

            Assert.AreEqual(expected: 3, actual: resultQuery.Primes.Count());
        }

        [TestMethod]
        [DataRow(-10)]
        [DataRow(0)]
        public void Should_Return_Error_When_Number_Lower_Or_Equal_Than_Zero(int number)
        {
            var resultQuery = CalculateDivisorQueries.GetDividersByNumber(number);

            Assert.IsFalse(resultQuery.Success);
        }
    }
}

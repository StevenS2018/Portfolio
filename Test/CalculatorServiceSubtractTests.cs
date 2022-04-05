using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Tests
{
    public class CalculatorServiceSubtractTests
    {
        private readonly CalculatorServiceSubtraction _sut;

        public CalculatorServiceSubtractTests()
        {
            _sut = new CalculatorServiceSubtraction();
        }
        [Theory]
        [InlineData(10,5, 5)]

        public void Subtract_Should_Pass(int numOne, int numTwo, int expected)
        {
            var results = _sut.Subtraction(numOne, numTwo);
            results.Should().Be(expected);
        }
    }
}

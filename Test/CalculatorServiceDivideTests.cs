using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Tests.Tests
{
    public class CalculatorServiceDivideTests
    {
        private readonly CalculatorServiceDivide _sut;

        public CalculatorServiceDivideTests()
        {
            _sut = new CalculatorServiceDivide();
        }
        [Theory]
        [InlineData(10.0, 5.0, 2.0)]
        public void Divide_Should_Pass(double numOne, double numTwo, double expected)
        {
            var results = _sut.Divide(numOne, numTwo);
            results.Should().Be(expected);
        }
    }
}

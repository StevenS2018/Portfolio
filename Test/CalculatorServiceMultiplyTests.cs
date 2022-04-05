using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Tests
{
    public class CalculatorServiceMultiplyTests
    {
        private readonly CalculatorServiceMultiply _sut;
         public CalculatorServiceMultiplyTests()
        {
            _sut = new CalculatorServiceMultiply();
        }
        [Theory]

        [InlineData(1.0,3.0, 3.0)]
         public void Multiply_Should_Pass(double numOne, double numTwo, double expected)
        {
            var results = _sut.Multiply(numOne, numTwo);

            results.Should().Be(expected);
        }
    }
}

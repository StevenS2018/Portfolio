using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;
using Xunit;
using FluentAssertions;

namespace TDDExercises.Tests.Test
{
    public class TipCalculatorServiceTests
    {
        private readonly TipCalculatorService _sut;

        public TipCalculatorServiceTests()
        {
            _sut = new TipCalculatorService();
        }
        [Theory]
        [InlineData(10.00, 0.15, 1.50)]
        public void TipCalculator_Should_Pass(double totalAmount, double tipPercentage, double expected)
        {
            var results = _sut.CalculateTip(totalAmount, tipPercentage);

            results.Should().Be(expected);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Tests.Test
{
    public class PinValidatorServiceTests
    {
        private readonly PinValidatorService _sut;

        public PinValidatorServiceTests()
        {
            _sut = new PinValidatorService();

        }
        [Theory]
        [InlineData(2018, 2018, true)]
        public void Pin_Should_Pass(int pin, int correctPin, bool expected)
        {
            var results = _sut.IsPin(pin, correctPin);

            results.Should().Be(expected);


        }
    }
}

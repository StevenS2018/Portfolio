using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using NSubstitute;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Tests
{
    public class AgeToDayServiceTestFail
    {
        private readonly AgeToDayServiceFail _sut;

        public AgeToDayServiceTestFail()
        {
            _sut = new AgeToDayServiceFail();
        }
        [Theory]
        [InlineData(1.0, 365.25)]
        public void AgeToDays_Should_Not_Pass(double age, double expected)
        {
            var result = _sut.AgeToDays(age);
            result.Should().NotBe(expected);
        }
    }
}

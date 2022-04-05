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
    public class AgeToDayServiceTest
    {
        private readonly AgeToDayService _sut;

        public AgeToDayServiceTest()
        {
            _sut = new AgeToDayService();
        }
        [Theory]
        [InlineData(1.0, 365.25)]
        public void AgeToDays_Should_Pass(double age, double expected)
        {
            var result = _sut.AgeToDays(age);
            result.Should().Be(expected);
        }
    }
}

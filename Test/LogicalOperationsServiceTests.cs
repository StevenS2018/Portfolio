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
    public class LogicalOperationsServiceTests
    {
        private readonly LogicalOperationsService _sut;

        public LogicalOperationsServiceTests()
        {
            _sut = new LogicalOperationsService();
        }
        [Theory]
        [InlineData(1, 0, true)]
        public void Or_Should_Pass(int numOne, int numTwo, bool expected)
        {
            var results = _sut.Or(numOne, numTwo);
            results.Should().Be(expected);
        }
    }
}

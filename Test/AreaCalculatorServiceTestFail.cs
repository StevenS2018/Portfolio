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
    public class AreaCalculatorServiceTestFail
    {
        private readonly AreaCalculatorServiceFail _sut;

        public AreaCalculatorServiceTestFail()
        {
            _sut = new AreaCalculatorServiceFail();
        }
        [Theory]
        [InlineData(12.5, 9.5, 114.75)]

        public void AreaOfTraingle_Should_Not_Pass(double tHeight, double tBase, double expected)
        {
            var results = _sut.GetAreaOfTriangle(tHeight, tBase);
            results.Should().NotBe(expected);

        }
      

    }
}

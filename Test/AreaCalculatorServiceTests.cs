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
    public class AreaCalculatorServiceTests
    {
        private readonly AreaCalculatorServiceTestFail _sut;

        public AreaCalculatorServiceTests()
        {
            _sut = new AreaCalculatorServiceTestFail();
        }
        [Theory]
        [InlineData(5.0, 10.0, 50.0)]
        public void AreaCalculatorService_Should_Pass(double tBase, double tHeight, double expected)
        {
            var result = _sut.GetAreaOfTriangle(tBase, tHeight);

            result.Should().Be(expected);


        }
    }
}

//In the body of the function create a variable named result set to _sut.AreaCalculatorService(tBase, tHeight); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
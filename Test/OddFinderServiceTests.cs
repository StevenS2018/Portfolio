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
    public class OddFinderServiceTests
    {
        private readonly OddFinderService _sut;

        public OddFinderServiceTests()
        {
            _sut = new OddFinderService();

        }
        [Theory]
        [InlineData(3, true)]
        public void IsNumberOdd_Should_Pass(int numOne, bool expected)
        {
            var result = _sut.IsOddNumber(numOne);

            result.Should().Be(expected);

        }
    }
}
//Add then an additional parameter for the return type called expected.
//Add the code annotation to the top of function called [Theory].
//Then add the code annotation [InlineData(3, true)] below the previous one.
//In the body of the function create a variable named result set to _sut.IsNumberOdd(number); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
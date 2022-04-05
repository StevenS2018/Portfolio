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
    public class EvenFinderServiceTests
    {
        private readonly EvenFinderService _sut;

        public EvenFinderServiceTests()
        {
            _sut = new EvenFinderService();
        }
        [Theory]
        [InlineData(2, true)]
        public void IsNumberEven_Should_Pass(int number, bool expected)
        {
            var result = _sut.IsNumberEven(number);

            result.Should().Be(expected);


        }

    }
}

//In the body of the function create a variable named result set to _sut.IsNumberEven(number); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
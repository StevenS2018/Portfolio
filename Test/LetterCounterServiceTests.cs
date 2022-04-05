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
    public class LetterCounterServiceTests
    {
        private readonly LetterCounterService _sut;
        
        public LetterCounterServiceTests()
        {
            _sut = new LetterCounterService();
        }
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 'L', 1)]
        public void GetLetterCount_Should_Pass(string sentence, char character, int expected)
        {
            var result = _sut.GetLetterCount(sentence, character);
                result.Should().Be(expected);
        }
    }
}
//In the body of the function create a variable named result set to _sut.GetLetterCount(sentence, character); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);

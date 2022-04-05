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
    public class PalindromeCheckerServiceTests
    {
        private readonly PalindromeCheckerService _sut;

        public PalindromeCheckerServiceTests()
        {
            _sut = new PalindromeCheckerService();
        }
        [Theory]
        [InlineData("otto", true)]
        public void IsPalidrome_Should_Pass(string word, bool expected)
        {
            var results = _sut.IsPalidrome(word);
            results.Should().Be(expected);

        }
    }
}
//In the body of the function create a variable named result set to _sut.IsPalindrome(word); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
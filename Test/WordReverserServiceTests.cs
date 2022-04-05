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
    public class WordReverserServiceTests
    {
        private readonly WordReverserService _sut;

        public WordReverserServiceTests()
        {
            _sut = new WordReverserService();
        }
        [Theory]
        [InlineData("John", "nhoJ")]

        public void ReversedWord_Should_Pass(string word, string expected)
        {
            var results = _sut.ReversedWord(word);
            results.Should().Be(expected);
            
        }
    }
}

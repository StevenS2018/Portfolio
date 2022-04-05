using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;
using Xunit;
using FluentAssertions;

namespace TDDExercises.Tests.Test
{
    public class LetterMultipleServiceTests
    {
        private readonly LetterMultiplierService _sut;

        public LetterMultipleServiceTests()
        {
            _sut = new LetterMultiplierService();
        }
        [Theory]
        [InlineData('J', 5, "JJJJJ")]
        public void LetterMultiple_Should_Pass(char letter, int value, string expected)
        {
            var result = _sut.LetterMultiple(letter, value);
            result.Should().Be(expected);


        }

    }
}

//Instantiate the _sut property in the constructor.
//Create a method called LetterMultiple_Should_Pass.
//Give it a return type of void.
//Give it parameters identical to what will be called by the method to be created in the LetterMultiplierService.cs file.
//Add then an additional parameter for the return type called expected.
//Add the code annotation to the top of function called [Theory].
//Then add the code annotation [InlineData('J', 5, "JJJJJ")] below the previous one.
//In the body of the function create a variable named result set to _sut.LetterMultiple(letter, value); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
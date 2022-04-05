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
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _sut;

        public CalculatorServiceTests()
        {
            _sut = new CalculatorService();
        }
        [Theory]
        [InlineData(10,5,15)]
        public void Add_Should_Pass(int numOne, int numTwo, int expected)
        {
            var results = _sut.Add(numOne, numTwo);

             results.Should().Be(expected);

        }

    }
}
//Create a method called Add_Should_Pass.
//Give it a return type of void.
//Give it parameters identical to what will be called by the method to be created in the CalculatorService.cs file.
//Add then an additional parameter for the return type called expected.
//Add the code annotation to the top of function called [Theory].
//Then add the code annotation [InlineData(10, 5, 15)] below the previous one.
//In the body of the function create a variable named result set to _sut.Add(numOne, numTwo); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
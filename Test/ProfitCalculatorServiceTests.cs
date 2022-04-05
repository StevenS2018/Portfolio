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
    public class ProfitCalculatorServiceTests
    {
        private readonly ProfitCalculatorService _sut;

        public ProfitCalculatorServiceTests()
        {
            _sut = new ProfitCalculatorService();
        }
        [Theory]
        [InlineData(100.00, 80.0, 0.2)]
        public void GetProfitMargin_Should_Pass(double revenue, double cost, double expected) 
        {
            var results = _sut.GetProfitMargin(revenue, cost);
            results.Should().Be(expected);
        }

    }



    
}
//Give it parameters identical to what will be called by the method to be created in the ProfitCalculatorService.cs file.
//Add then an additional parameter for the return type called expected.
//Add the code annotation to the top of function called [Theory].
//Then add the code annotation [InlineData(100.00, 80.0, 0.2)] below the previous one.
//In the body of the function create a variable named result set to _sut.GetProfitMargin(revenue, cost); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
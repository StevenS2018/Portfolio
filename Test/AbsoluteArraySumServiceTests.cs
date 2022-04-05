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
    public class AbsoluteArraySumServiceTests
    {
        private readonly AbsoluteArraySumService _sut;

        public AbsoluteArraySumServiceTests()
        {
            _sut = new AbsoluteArraySumService();
        }
        public static IEnumerable<object[]> Data => new List<object[]>
        {
          new object[]
          {
             1, 2, 1, 4
          },
          new object[]
          {
             -1,-2,3, 6
          }
         };
        [Theory]
        [MemberData(nameof(Data))]
        public void AbsoluteSummation_Should_Pass(int num1, int num2, int num3, int expected)
        {
            int[] inputArray = new[] { num1, num2, num3 };
            var results = _sut.AbsoluteSummation(inputArray);

            results.Should().Be(expected);


        }
    }
}
//Create an array variable called inputArray and assign all the parameters to the array except the expected value.
//In the body of the function create a variable named result set to _sut.AbsoluteSummation(inputArray); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and Be() with the result variable.
//It should look like this result.Should().Be(expected);.
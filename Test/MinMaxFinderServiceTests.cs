using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.ClassLibrary
{
    public class MinMaxFinderServiceTests
    {
        private readonly MinMaxFinderService _sut;

        public MinMaxFinderServiceTests()
        {
            _sut = new MinMaxFinderService();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void MinMaxArrayGenerator_Should_Pass(int num1, int num2, int num3, int[] expected)
        {
            var inputArray = new int[] { num1, num2, num3 };

            var results = _sut.MinMaxGenerator(inputArray);

            results.Should().BeEquivalentTo(expected);
         }
        public static IEnumerable<object[]> Data => new List<object[]>
                    {
                      new object[]{
                      1,2,100,new int[]{1,100}

                    },
                      new object[]{
                       0,2,99,new int[]{0,99}
                        }
                     };


    }
}

//Create an array variable called inputArray and assign all the parameters to the array except the expected value.
//In the body of the function create a variable named result set to _sut.MinMaxArrayGenerator(inputArray); with the appropriate datatype.
//At the end of the function use the FluentAssertion methods Should() and BeEquivalentTo() with the result variable.
//It should look like this result.Should().BeEquivalentTo(expected);.
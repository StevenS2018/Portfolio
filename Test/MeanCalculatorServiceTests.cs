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
    public class MeanCalculatorServiceTests
    {
        private readonly MeanCalculatorService _sut;

        public MeanCalculatorServiceTests()
        {
            _sut = new MeanCalculatorService();
        }
        public static IEnumerable<object[]> Data => new List<object[]>
 {
    new object[]
    {
        1.00, 2.00, 1.00, 1.3333333333333333
    },
    new object[]
    {
        1.00,2.00,3.00, 2.0
    }
};

        [Theory]
        [MemberData(nameof(Data))]
        public void Mean_Should_Pass(double numOne, double numTwo, double numThree, double expected)
        {
            var results = _sut.GetMeanFromIEnumerable(new[] { numOne, numTwo, numThree });
            
            results.Should().Be(expected);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class CalculatorService
    {
        public int Add(int numOne, int numTwo)
        {
            var sum = numOne + numTwo;
            return sum;
        }

    }
}

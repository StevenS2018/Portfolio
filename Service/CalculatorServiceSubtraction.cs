using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace TDDExercises.ClassLibrary
{
    public class CalculatorServiceSubtraction
    {
        public int Subtraction(int numOne, int numTwo)
        {
            int diffrence = numOne - numTwo;

            return diffrence;
        }
    }
}

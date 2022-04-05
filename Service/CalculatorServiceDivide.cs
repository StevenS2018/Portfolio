using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class CalculatorServiceDivide
    {
        public double Divide(double numOne, double numTwo)
        {
            var sum = numOne / numTwo;
            return sum;
        }

    }
}

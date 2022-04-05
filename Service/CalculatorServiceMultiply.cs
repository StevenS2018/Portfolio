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
    public class CalculatorServiceMultiply
    {
        public double Multiply(double numOne,double numTwo)
        {
            double sum = numOne * numTwo;
            return sum;
        }
    }
}

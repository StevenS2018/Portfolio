using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class TipCalculatorService
    {
        public double CalculateTip(double totalAmount, double tipPercentage)
        {
            double evaluation = totalAmount  * tipPercentage;

            return evaluation;  
        }
    }
}

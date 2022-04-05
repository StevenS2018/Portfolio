using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class LogicalOperationsService
    {
        public bool Or(int numOne, int numTwo)
        {
            var boolNumOne = Convert.ToBoolean(numOne);
            var boolNumTwo = Convert.ToBoolean(numTwo);
            return boolNumOne || boolNumTwo;
        }

    }
}

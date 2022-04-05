using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class OddFinderService
    {
        public bool IsOddNumber(int numOne)
        {
            bool evaluation = false;

            if(numOne % 2 != 0)
            {
                evaluation = true;
            }
            return evaluation;
        }
    }
}

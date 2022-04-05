using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class EvenFinderService
    {
        public bool IsNumberEven(int number)
        {
            bool evaluation = false;

            if(number % 2 == 0)
            {
                evaluation = true;
            }
            return evaluation;
        }
    }
}

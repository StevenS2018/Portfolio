using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;
using TDDExercises.Tests;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class AbsoluteArraySumService
    {
        public int AbsoluteSummation(int[] values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += Math.Abs(value);
            }
            return sum;
        }
    }

          
}

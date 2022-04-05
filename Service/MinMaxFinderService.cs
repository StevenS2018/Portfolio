using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class MinMaxFinderService
    {
        public int[] MinMaxGenerator(int[] values)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int value in values)
            {
                if(value > max)
                {
                    max = value;

                }
                if(value < min)
                {
                    min = value;
                }
                
            }
            return new int[] { min, max };
        }
    }
}

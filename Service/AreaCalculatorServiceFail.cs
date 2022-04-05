using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class AreaCalculatorServiceFail
    {
        public double GetAreaOfTriangle(double tBase, double tHeight)
        {
            double area = (tHeight * tBase);
            return area;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class ProfitCalculatorService
    {
       public double GetProfitMargin(double revenue, double cost)
        {
            double profitMargin = (revenue - cost) / revenue;
            return profitMargin;
        }

    }
}

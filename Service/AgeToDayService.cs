using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.Tests;

namespace TDDExercises.ClassLibrary
{
    public class AgeToDayService
    {
        public double AgeToDays(double age)
        {
            var convertedAgeToDays = age * 365.25;
            return convertedAgeToDays;
        }
    }
}

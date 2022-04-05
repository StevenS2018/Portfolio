using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
     public class PinValidatorService
    {
        public bool IsPin(int pin, int correctPin)
        {
            bool isPin = false;
            string message;

            if( pin == correctPin)
            {
                isPin = true;
                message = "Access Accepted";

            }
           
            return isPin;

        }
    }
}

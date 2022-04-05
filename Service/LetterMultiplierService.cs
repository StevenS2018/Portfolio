using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class LetterMultiplierService
    {
        public string LetterMultiple(char letter, int value)
        {
            var multifiedWord = "";

            for (var i = 0; i < value; i++) multifiedWord += letter;

            return multifiedWord;

        }
    }
}

//public string LetterMultiple(char letter, int value)
//{
//    var multifiedWord = "";


//    for (var i = 0; i < value; i++) multifiedWord += letter;


//    return multifiedWord;
//}

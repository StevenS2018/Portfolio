using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class LetterCounterService
    {
        public int GetLetterCount(string sentence, char character)
        {
            int totalLetters = 0;

            foreach(char value in sentence)
            {
                totalLetters += value == character ? 1 : 0;
            }
            return totalLetters;


        }
    }
}

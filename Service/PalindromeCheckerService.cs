using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class PalindromeCheckerService
    {
        public bool IsPalidrome(string word)
        {
            char[] array = word.ToCharArray();

            Array.Reverse(array);
            string reversedWord = new string(array);
            return reversedWord.Equals(word);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDExercises.ClassLibrary
{
    public class WordReverserService
    {
        public string ReversedWord(string word)
        {
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i].ToString();

            }
            return reversedWord;
        }
    }
}

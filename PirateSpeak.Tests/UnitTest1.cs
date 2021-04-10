using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PirateSpeak.Tests
{
    public class PirateTranslator
    {
        [Theory]
        [InlineData("ortsp", new string[] { "sport", "parrot", "ports", "matey" }, new string[] { "sport", "ports" })]
        [InlineData("estka", new string[] { "steak", "stake", "takes", "makes", "teams" }, new string[] { "steak", "stake", "takes" })]
        public void the_possible_words_are_chosen_that_would_fit_the_translation(string word, string[] words, string[] expected)
        {
            var translator = new Pirate();
            var myList = translator.GetPossibleWords(word, words.ToList());
            Assert.Equal(expected, myList);
        }

    } }
